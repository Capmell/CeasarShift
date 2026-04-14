using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarShiftTest
{
    public class Cypher
    {
        // I am keeping this here so you can kind of see the thought process I went throught this did not end up working and I had to put it per class I tried to make thing slightly easier
        // kept getting errors didnt work out
        string input;
        int key;
        StringBuilder result = new StringBuilder();



        public string Shift(string input, int key)
        {
            StringBuilder result = new StringBuilder();

            int optimizedKey = key % 26;

            foreach (char shifting in input)
            {
              
                if (char.IsLetter(shifting))
                {
                    char offset = char.IsLower(shifting) ? 'a' : 'A';

                
                    int shiftedValue = (shifting - offset + optimizedKey) % 26;

                   
                    if (shiftedValue < 0) shiftedValue += 26;

                    result.Append((char)(shiftedValue + offset));
                }
                else
                {
                   
                    result.Append(shifting);
                }
            }

            return result.ToString();
        }

        public string UnShift(string input, int key)
        {
            StringBuilder result = new StringBuilder();

           
            int keys = key % -26;

            foreach (char shifting in input)
            {
                if (char.IsLetter(shifting))
                {
                    char offset = char.IsLower(shifting) ? 'a' : 'A';


                    int shiftedValue = (shifting - offset + keys) % -26;

                  
                    if (shiftedValue < 0)
                    {
                        shiftedValue += -26;
                    }

                    result.Append((char)(shiftedValue + offset));
                }
                else
                {
                    result.Append(shifting);
                }
               
            }
            return result.ToString();
        }

            
        }
    }

