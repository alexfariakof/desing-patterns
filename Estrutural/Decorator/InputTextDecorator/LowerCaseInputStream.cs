namespace InputTextDecorator
{
    public class LowerCaseInputStream : Stream
    {
        private Stream baseStream;
        public LowerCaseInputStream(Stream baseStream)
        {
            this.baseStream = baseStream;
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int bytesRead = baseStream.Read(buffer, offset, count);
            System.Globalization.TextInfo textInfo = System.Globalization.CultureInfo.CurrentCulture.TextInfo;
            for (int i = 0; i < bytesRead; i++)
            {
                buffer[offset + i] = (byte)textInfo.ToLower((char)buffer[offset + i]);
            }

            return bytesRead;
        }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void Flush() { }
        public override long Seek(long offset, SeekOrigin origin) { throw new NotImplementedException(); }
        public override void SetLength(long value) { throw new NotImplementedException(); }
        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => this.baseStream.Length;
        public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}