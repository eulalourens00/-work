namespace _21_Pract_Morse_code_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Morse_code morse = new Morse_code();
            morse.ConvertToMorse(morse.Code);
            morse.ConvertMorseToTheText(morse.Code);

        }
    }
}
