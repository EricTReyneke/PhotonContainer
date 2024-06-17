using PhotonContainer.Business.Interfaces;

namespace PhotonContainer.Business.ReverseStrings
{
    public class PhotonReversal : IStringReversals
    {
        #region Fields
        ITestStrings _testStrings;
        #endregion

        #region Constructors
        public PhotonReversal(ITestStrings testStrings) =>
            _testStrings = testStrings;
        #endregion

        #region Public Methods
        public string ReverseString()
        {
            if (string.IsNullOrEmpty(_testStrings.StringToReverse))
                return string.Empty;

            List<(char ch, int index)> chars = ExtractNonLettersAndDigitsWithIndices(_testStrings.StringToReverse);
            List<int> upperCharacterIndices = ExtractUpperCharacterIndices(_testStrings.StringToReverse);

            string lowerCaseString = _testStrings.StringToReverse.ToLower();
            List<char> stringWithoutPunc = ExtractAndReverseLettersAndDigits(lowerCaseString);

            InsertNonLettersAndDigits(stringWithoutPunc, chars);
            ApplyUpperCaseIndices(stringWithoutPunc, upperCharacterIndices);

            return new string(stringWithoutPunc.ToArray());
        }
        #endregion

        #region Private Methods
        private List<(char ch, int index)> ExtractNonLettersAndDigitsWithIndices(string input) =>
            input
                .Select((ch, index) => (ch, index))
                .Where(tuple => !char.IsLetterOrDigit(tuple.ch) && tuple.ch != ' ')
                .ToList();

        private List<int> ExtractUpperCharacterIndices(string input) =>
            input
                .Select((ch, index) => new { ch, index })
                .Where(charInfo => char.IsUpper(charInfo.ch))
                .Select(charInfo => charInfo.index)
                .ToList();

        private List<char> ExtractAndReverseLettersAndDigits(string input)
        {
            List<char> result = input
                .Where(ch => char.IsLetterOrDigit(ch) || ch == ' ')
                .ToList();

            result.Reverse();
            return result;
        }

        private void InsertNonLettersAndDigits(List<char> list, List<(char ch, int index)> chars)
        {
            foreach (var values in chars)
                list.Insert(values.index, values.ch);
        }

        private void ApplyUpperCaseIndices(List<char> list, List<int> indices)
        {
            foreach (int index in indices)
                list[index] = char.ToUpper(list[index]);
        }
        #endregion
    }
}