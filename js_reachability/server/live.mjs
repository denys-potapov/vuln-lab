// Live updates over websockets (ES module)
import { WebSocketServer } from 'ws';

export function startLive(server) {
  const wss = new WebSocketServer({ server });
  wss.on('connection', (socket) => socket.send(JSON.stringify({ hello: 'live' })));
  return wss;
}
