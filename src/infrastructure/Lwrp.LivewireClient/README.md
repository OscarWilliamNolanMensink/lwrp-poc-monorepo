# LiveWireClient

## Ressilient Connections

### EnsureConnectedAsync

1. Fast path check: if there's already a working connection (client is connected & stream/reader/writer non-null), it just returns.
2. If not, it grabs _lock so only one caller is allowed to recreate the connection.
3. It checks again inside the lock (maybe someone else fixed it between step 1 and getting the lock).
4. Disposes any old junk (half-broken client, old stream).
5. Makes a fresh TcpClient, connects to Host:Port, and sets up the stream + reader/writer.



- You reuse one TCP connection instead of constantly opening and closing connections in each service.
- You have controlled reconnect when needed.
- You avoid race conditions where two API calls simultaneously try to reconnect and stomp on each other.

### SendCommandAsync

1. Make sure we have a live connection (EnsureConnectedAsync).

2. Try to:
    - WriteLineAsync(command) → sends "VER\n", "IP\n", "LOGIN secret\n", etc.
    - ReadLineAsync() → reads the single line response.

3. If a network-related error happens:
    - IOException or SocketException are interpreted as “connection is bad”.
    - Call ReconnectAsync to repair the TCP connection.
    - Retry the command once on the fresh connection.

## ReconnectAsync

1. Grabs _lock again to ensure only one reconnect is happening.
2. Disposes whatever state we had (reader/writer/stream/client).
3. Creates a new TcpClient.

4. Tries a series of connection attempts with increasing delays:
0 ms, 500 ms, 1000 ms, 2000 ms, 5000 ms.
5. On each attempt:
    - Try ConnectAsync.
    - If it works: set up stream/reader/writer and return (success).
    - If it fails: remember the exception and try again after the next delay.

6.  If all attempts fail, throw a clear InvalidOperationException("Could not reconnect…", last).
