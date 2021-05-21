using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Inventory
{
    class Vigenere
    {
        private char[,] vigenere_square = new char[26, 26];
        private string key_word = "bohemianrhapsody"; // :)

        public Vigenere()
        {
            populate_vigenere_square();
        }

        private void populate_vigenere_square()
        {
            for ( int i = 0; i < 26; ++i )
            {
                for ( int j = 0; j < 26; ++j )
                {
                    int letter_increment = 0; // Increment by this each put
                    char start_letter = (char)(97 + i); // Start at ASCII letter i
                    char letter_to_put = (char)(start_letter + letter_increment); // Increment to next letter

                    vigenere_square[i, j] = letter_to_put; // Insert letter
                }
            }
        }
    }
}
