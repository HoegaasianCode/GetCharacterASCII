using System;

namespace GetCharCode
{
    public class CharBois
    {
        private char _char;
        private string _string;

        public CharBois(char char1)
        {
            _char = char1;
        }

        public void InvertCase()
        {
            if (char.IsUpper(_char)) _string = _char.ToString().ToLower();
            else _string = _char.ToString().ToUpper();
        }

        public void ReConvert()
        {
            _char = Convert.ToChar(_string);
        }

        public int GetASCII() => _char;
    }
}
