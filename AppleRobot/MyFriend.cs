using System;
using System.Net.Sockets;

namespace MySocketServer {
	internal class MyFriend {
		public Socket socket;
		public byte[] Rcvbuffer;
		public MyFriend(Socket s) {
			this.socket = s;
		}
		public void ClearBuffer() {
			this.Rcvbuffer = new byte[1024];
		}
		public void Dispose() {
			try {
				this.socket.Shutdown(SocketShutdown.Both);
				this.socket.Close();
			} finally {
				this.socket = null;
				this.Rcvbuffer = null;
			}
		}
	}
}