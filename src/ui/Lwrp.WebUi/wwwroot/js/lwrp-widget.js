// Simple React widget for LWRP control, using the API

(function () {
    const e = React.createElement;

    function usePolling(url, intervalMs) {
        const [state, setState] = React.useState({ loading: true, error: null, data: null });

        React.useEffect(() => {
            let cancelled = false;

            async function fetchOnce() {
                try {
                    const res = await fetch(url);
                    const json = await res.json();
                    if (!cancelled) {
                        setState({ loading: false, error: null, data: json });
                    }
                } catch (err) {
                    if (!cancelled) {
                        setState({ loading: false, error: err.message || String(err), data: null });
                    }
                }
            }

            fetchOnce();
            const id = setInterval(fetchOnce, intervalMs);

            return () => {
                cancelled = true;
                clearInterval(id);
            };
        }, [url, intervalMs]);

        return state;
    }

    function LwrpWidget() {
        
        const apiBase = "http://localhost:5150/api";
        const health = usePolling(`${apiBase}/lwrp/health`, 5000);

        const [loginPassword, setLoginPassword] = React.useState("");
        const [loginMessage, setLoginMessage] = React.useState(null);

        const [verResult, setVerResult] = React.useState(null);
        const [ipResult, setIpResult] = React.useState(null);

        async function doLogin(ev) {
            ev.preventDefault();
            setLoginMessage("Logging in...");
            try {
                const res = await fetch(`${apiBase}/Login`, {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: JSON.stringify({ password: loginPassword })
                });
                const json = await res.json();
                if (json.success) {
                    setLoginMessage("Login successful");
                } else {
                    setLoginMessage(json.error || "Login failed");
                }
            } catch (err) {
                setLoginMessage("Login exception: " + (err.message || String(err)));
            }
        }

        async function loadVer() {
            setVerResult("Loading...");
            try {
                const res = await fetch(`${apiBase}/ver`);
                const json = await res.json();
                setVerResult(JSON.stringify(json, null, 2));
            } catch (err) {
                setVerResult("Error: " + (err.message || String(err)));
            }
        }

        async function loadIp() {
            setIpResult("Loading...");
            try {
                const res = await fetch(`${apiBase}/ip`);
                const json = await res.json();
                setIpResult(JSON.stringify(json, null, 2));
            } catch (err) {
                setIpResult("Error: " + (err.message || String(err)));
            }
        }

        const healthBadge = (() => {
            if (health.loading) {
                return e("span", { className: "badge bg-secondary" }, "Checking...");
            }
            if (health.error) {
                return e("span", { className: "badge bg-danger" }, "Error");
            }
            if (!health.data) {
                return e("span", { className: "badge bg-warning" }, "No data");
            }
            return health.data.isHealthy
                ? e("span", { className: "badge bg-success" }, "Connected")
                : e("span", { className: "badge bg-danger" }, "Disconnected");
        })();

        return e("div", { className: "card" },
            e("div", { className: "card-header d-flex justify-content-between align-items-center" },
                e("span", null, "LWRP Device"),
                healthBadge
            ),
            e("div", { className: "card-body" },
                // Health details
                e("div", { className: "mb-3" },
                    e("h5", null, "Connection status"),
                    health.loading && e("div", null, "Loading health..."),
                    health.error && e("div", { className: "text-danger" }, health.error),
                    health.data && e("div", null, health.data.message)
                ),

                // Login form
                e("form", { className: "mb-3", onSubmit: doLogin },
                    e("h5", null, "Login"),
                    e("div", { className: "input-group mb-2" },
                        e("input", {
                            type: "password",
                            className: "form-control",
                            placeholder: "Password (leave empty for read-only)",
                            value: loginPassword,
                            onChange: (ev) => setLoginPassword(ev.target.value)
                        }),
                        e("button", { type: "submit", className: "btn btn-primary" }, "Login")
                    ),
                    loginMessage && e("div", { className: "small" }, loginMessage)
                ),

                // VER
                e("div", { className: "mb-3" },
                    e("h5", null, "Version (VER)"),
                    e("button", { className: "btn btn-outline-primary btn-sm mb-2", onClick: loadVer }, "Load VER"),
                    verResult && e("pre", { className: "small bg-light p-2 border" }, verResult)
                ),

                // IP
                e("div", { className: "mb-3" },
                    e("h5", null, "IP Configuration"),
                    e("button", { className: "btn btn-outline-primary btn-sm mb-2", onClick: loadIp }, "Load IP"),
                    ipResult && e("pre", { className: "small bg-light p-2 border" }, ipResult)
                )
            )
        );
    }

    function renderLwrpWidget() {
        const rootElement = document.getElementById("lwrp-react-root");
        if (!rootElement) return;

        const root = ReactDOM.createRoot(rootElement);
        root.render(React.createElement(LwrpWidget));
    }

    // Expose a hook so Blazor can call it when the page renders
    window.renderLwrpWidget = renderLwrpWidget;

    // Optional: auto-run if the element exists at load
    document.addEventListener("DOMContentLoaded", () => {
        if (document.getElementById("lwrp-react-root")) {
            renderLwrpWidget();
        }
    });
})();
