using System.Windows.Forms;

namespace blahblah
{
    class Talker
    {
        public static int blah(string thingTosay, int numberOfTimes)
        {
            string FinalString = "";
            for (int i = 0; i <= numberOfTimes; i++)
            {
                FinalString = FinalString + thingTosay + "\n";
            }
            MessageBox.Show(FinalString);
            return FinalString.Length;
        }
    }
}
