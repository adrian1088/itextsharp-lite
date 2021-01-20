namespace iTextSharp.Rtf.Parser.Exceptions
{
    public class RtfUnknownCtrlWordException : RtfParserException
    {
        // constructors

        /**
        * Constructs a <CODE>RtfParserException</CODE> whithout a message.
        */

        public RtfUnknownCtrlWordException() : base("Unknown control word.")
        {
        }
    }
}