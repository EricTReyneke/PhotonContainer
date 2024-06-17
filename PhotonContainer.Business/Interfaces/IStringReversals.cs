namespace PhotonContainer.Business.Interfaces
{
    public interface IStringReversals
    {
        /// <summary>
        /// Reverses the given string and keeps the punctuation in the original place.
        /// </summary>
        /// <returns>Reversed string.</returns>
        string ReverseString();
    }
}