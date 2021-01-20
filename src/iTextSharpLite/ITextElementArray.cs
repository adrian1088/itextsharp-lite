using System;

namespace iTextSharp
{
    /// <summary>
    /// Interface for a text element to which other objects can be added.
    /// </summary>
    /// <seealso cref="T:iTextSharp.Phrase"/>
    /// <seealso cref="T:iTextSharp.Paragraph"/>
    /// <seealso cref="T:iTextSharp.Section"/>
    /// <seealso cref="T:iTextSharp.ListItem"/>
    /// <seealso cref="T:iTextSharp.Chapter"/>
    /// <seealso cref="T:iTextSharp.Anchor"/>
    /// <seealso cref="T:iTextSharp.Cell"/>
    public interface ITextElementArray : IElement
    {
        /// <summary>
        /// Adds an object to the TextElementArray.
        /// </summary>
        /// <param name="o">an object that has to be added</param>
        /// <returns>true if the addition succeeded; false otherwise</returns>
        bool Add(Object o);
    }
}