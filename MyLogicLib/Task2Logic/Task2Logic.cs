namespace MyLogicLib.Task2Logic
{
    public static class Task2Logic
    {
        public static string[] GetNewTextFile(string[] numbersFile, string[] textFile)
        {
            string[] newTextFile = new string[textFile.Length];
            for (int i = 0; i < textFile.Length; i++)
            {
                if (i < numbersFile.Length)
                {
                    newTextFile[i] = string.Format("{1} {0} {1}", textFile[i], numbersFile[i]);
                }
                else
                {
                    newTextFile[i] = textFile[i];
                }
            }
            return newTextFile;
        }
    }
}