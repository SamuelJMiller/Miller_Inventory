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
        private int letter_increment;

        public Vigenere()
        {
            populate_vigenere_square();
        }

        // Create the square:
        private void populate_vigenere_square()
        {
            for ( int i = 0; i < 26; ++i )
            {
                letter_increment = 0; // Increment by this each put
                for ( int j = 0; j < 26; ++j )
                {
                    char start_letter = (char)(65 + i); // Start at ASCII letter i
                    char letter_to_put = (char)(start_letter + letter_increment); // Increment to next letter

                    if (letter_to_put > 90)
                    {
                        letter_to_put -= (char) 26; // Loop around after 'z'
                    }

                    vigenere_square[i, j] = letter_to_put; // Insert letter
                    ++letter_increment;
                }
            }
        }

        // Crack the cypher using the "key":
        public string decode_message(string encoded_message, string keyword)
        {
            StringBuilder builder = new StringBuilder();

            // Ciphertext "is where in" key:
            for ( int j = 0; j < encoded_message.Length; ++j )
            {
                for ( int i = 0; i < 26; ++i )
                {
                    // Check the row of the key letter for the right decode letter:
                    if (vigenere_square[i, keyword[i] - 65] == encoded_message[i])
                    {
                        // Then expand the decoded message:
                        builder.Append(vigenere_square[i, 0]);
                    }
                }
            }

            string finished = builder.ToString();
            return finished;
        }

        // Get the table, mostly for testing:
        public char[,] get_table()
        {
            return vigenere_square;
        }
    }
}
