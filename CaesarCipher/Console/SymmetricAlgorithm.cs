using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class SymmetricAlgorithm
    {
        private int key { get; set; }
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public String Enkripto(String plainText, int key)
        {
            this.key = key;
            String cipherText = "";
            for (int i = 0; i < plainText.Length; i++)
            {
                if (!char.IsLetter(plainText[i]))
                {

                    cipherText += plainText[i];

                }
                else
                {
                    if (char.IsUpper(plainText[i]))
                    {
                        int charPosition = ALPHABET.IndexOf(plainText[i]);
                        int keyVal = (this.key + charPosition) % 26;
                        char replaceVal = ALPHABET[keyVal];
                        cipherText += replaceVal;

                    }
                    else
                    {
                        int charPosition = alphabet.IndexOf(plainText[i]);
                        int keyVal = (this.key + charPosition) % 26;
                        char replaceVal = alphabet[keyVal];
                        cipherText += replaceVal;
                    }


                }

            }
            return cipherText;
        }


        public String Dekripto(String cipherText)
        {
            String plainText = "";
            for (int i = 0; i < cipherText.Length; i++)
            {

                if (!char.IsLetter(cipherText[i]))
                {
                    plainText += cipherText[i];
                }
                else
                {

                    if (char.IsUpper(cipherText[i]))
                    {
                        int charPosition = ALPHABET.IndexOf(cipherText[i]);
                        int keyVal = (charPosition - this.key) % 26;
                        if (keyVal < 0)
                        {
                            keyVal = ALPHABET.Length + keyVal;
                        }
                        char replaceVal = ALPHABET[keyVal];
                        plainText += replaceVal;

                    }
                    else
                    {
                        int charPosition = alphabet.IndexOf(cipherText[i]);
                        int keyVal = (charPosition - this.key) % 26;
                        if (keyVal < 0)
                        {
                            keyVal = alphabet.Length + keyVal;
                        }
                        char replaceVal = alphabet[keyVal];
                        plainText += replaceVal;

                    }


                }

            }
            return plainText;
        }


    }
}
