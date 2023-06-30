using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RandomPassword
{
    public partial class RandomPasswordForm : Form
    {
        readonly char[] BigLetters;
        readonly char[] SmallLetters;
        readonly char[] Numbers;
        readonly char[] SpecialCharacters;
        const int MaxPasswordLength = 25;

        public RandomPasswordForm()
        {
            InitializeComponent();

            BigLetters = FillCharacterArray(65, 90);
            SmallLetters = FillCharacterArray(97, 122);
            Numbers = FillCharacterArray(48, 57);

            var SpecialCharacters_List = FillCharacterArray(33, 47).ToList();
            SpecialCharacters_List.AddRange(FillCharacterArray(58, 64));
            SpecialCharacters = SpecialCharacters_List.ToArray();

            string MaxLengthText = $"{MaxPasswordLength} )";
            PasswordLengthLabel.Text = PasswordLengthLabel.Text.Substring(0, PasswordLengthLabel.Text.Length - MaxLengthText.Length) + MaxLengthText;
        }

        private char[] FillCharacterArray(int StartIndex, int EndIndex) => Enumerable.Range(StartIndex, 1 + EndIndex - StartIndex).Select(i => (char)i).ToArray();

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            List<char> PossibleCharacters = new List<char>();
            if (BigLetterCheckBox.Checked) { PossibleCharacters.AddRange(BigLetters); }
            if (SmallLetterCheckBox.Checked) { PossibleCharacters.AddRange(SmallLetters); }
            if (NumberCheckBox.Checked) { PossibleCharacters.AddRange(Numbers); }
            if (SpecialCharacterCheckBox.Checked) { PossibleCharacters.AddRange(SpecialCharacters); }

            string Password = "";
            if (PossibleCharacters.Count > 0)
            {
                if (int.TryParse(PasswordLengthTextBox.Text, out int PasswordLength))
                {
                    if (PasswordLength <= MaxPasswordLength)
                    {
                        for (int i = 0; i < PasswordLength; i++)
                        {
                            Password += PossibleCharacters[random.Next(PossibleCharacters.Count)];
                        }
                    }
                }
            }
            PasswordTextBox.Text = Password;
        }
    }
}