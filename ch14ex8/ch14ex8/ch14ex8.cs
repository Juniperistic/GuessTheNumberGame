using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*************************************************************************/
/* Program Name:     Ch14Ex8.cs                                          */
/* Date:             03/22/2022                                     	 */
/* Programmer:       Miranda Morris                                 	 */
/* Class:            CSCI 234                                            */
/*                                                    				     */
/* Program Description: The purpose of this program is to create a number*/
/* guessing game that generates a random number that must be guessed.    */
/* Additionally, the colors of the textbox are meant to change based on  */
/* how close or far the number you guessed is from the generated number. */
/*                                                                       */
/* Input: a number that you are guessing equals the generated one        */
/*                                                                       */
/* Output: whether the number is less than, greater than, or equal to    */
/* the generated number                                                  */
/*                                                                       */
/* Givens: The number is between 1-1000                             	 */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input Data: computerNumber = 800;                    */
/*                                                                       */
/* List the Testing Output Data:  400, blue, too low                     */
/*                                450, red, too low                      */
/*                                850, red, too high                     */
/*                                800, green, correct, also enter a new  */
/*                                guess button is disabled now           */
/*                                                                       */
/*************************************************************************/

namespace ch14ex8
{
    static class ch14ex8
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
