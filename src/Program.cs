//Target framework: .NET Core 3.1
using System;

namespace ArcheryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ax, Ay, Bx, By, Cx, Cy;

            int A_set, B_set, C_set;

            int A_health, B_health, C_health;

            int A_score = 0;
            int B_score = 0;
            int C_score = 0;

            string A_condition = "";
            string B_condition = "";
            string C_condition = "";

            Console.WriteLine("Enter the location of A: ");
            // Ax Location
            Console.Write("Ax:");

            var input = Console.ReadLine();

            // TryParse(String, Int32) 
            // Converts the string representation of a number to its 32-bit signed integer equivalent.
            // A return value indicates whether the conversion succeeded.

            if (!int.TryParse(input, out Ax))
            {
                Console.WriteLine("Your entry is invalid.");
                Console.ReadLine();
                return;
            }

            // Ay Location
            Console.Write("Ay:");

            input = Console.ReadLine();

            if (!int.TryParse(input, out Ay))
            {
                Console.WriteLine("Your entry is invalid.");
                Console.ReadLine();
                return;
            }

            // Controling the validation of Ax and Ay
            if (Ax < -10 || Ax > 10 || Ay < -10 || Ay > 10)
            {
                Console.WriteLine("Your entry is invalid.");
                Console.ReadLine();
                return;
            }

            Random rand = new Random();

            // Random coordinant for B with range of [-10, -10]
            Bx = rand.Next(-10, 11);
            By = rand.Next(-10, 11);

            // Random coordinant for C with range of [-10, -10]
            Cx = rand.Next(-10, 11);
            Cy = rand.Next(-10, 11);

            // Random sets for arrow and shields
            int random_number = rand.Next(0, 6);

            if (random_number == 0)
            {
                A_set = 1; B_set = 2; C_set = 3;
            }
            else if (random_number == 1)
            {
                A_set = 1; B_set = 3; C_set = 2;
            }
            else if (random_number == 2)
            {
                A_set = 2; B_set = 1; C_set = 3;
            }
            else if (random_number == 3)
            {
                A_set = 2; B_set = 3; C_set = 1;
            }
            else if (random_number == 4)
            {
                A_set = 3; B_set = 1; C_set = 2;
            }
            else
            {
                A_set = 3; B_set = 2; C_set = 1;
            }

            // Random health for players
            random_number = rand.Next(0, 6);

            if (random_number == 0)
            {
                A_health = 60; B_health = 80; C_health = 100;
            }
            else if (random_number == 1)
            {
                A_health = 60; B_health = 100; C_health = 80;
            }
            else if (random_number == 2)
            {
                A_health = 80; B_health = 60; C_health = 100;
            }
            else if (random_number == 3)
            {
                A_health = 80; B_health = 100; C_health = 60;
            }
            else if (random_number == 4)
            {
                A_health = 100; B_health = 60; C_health = 80;
            }
            else
            {
                A_health = 100; B_health = 80; C_health = 60;
            }

            // Status of the Archers
            Console.Write('\n');
            Console.WriteLine("A: (" + Ax + ',' + Ay + ")  Set " + A_set + "  Health: " + A_health);
            Console.WriteLine("B: (" + Bx + ',' + By + ")  Set " + B_set + "  Health: " + B_health);
            Console.WriteLine("C: (" + Cx + ',' + Cy + ")  Set " + C_set + "  Health: " + C_health);
            Console.Write('\n');

            // Coordinate System
            Console.WriteLine("    +---------------------^---------------------+");
            Console.WriteLine(" 10 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  9 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  8 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  7 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  6 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  5 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  4 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  3 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  2 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  1 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  0 |---------------------+--------------------->");
            Console.WriteLine(" -1 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -2 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -3 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -4 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -5 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -6 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -7 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -8 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -9 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-10 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("    +-------------------------------------------+");
            Console.WriteLine("      0 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 0");

            Console.Write('\n');

            int AB_distance = (Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By);
            int BC_distance = (Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy);
            int AC_distance = (Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy);

            int AB_manhattan_distance = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);
            int BC_manhattan_distance = Math.Abs(Bx - Cx) + Math.Abs(By - Cy);
            int AC_manhattan_distance = Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy);

            int max_distance = 15 * 15;

            // Round 1
            // find the closest players

            if (AB_distance < BC_distance && AB_distance < AC_distance)
            {

                // A and B are closest
                if (AB_distance > max_distance)
                {
                    Console.WriteLine("Archers are too far apart. No attacks");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Round 1: A-B");

                if ((A_set == 2 && B_set == 1) || (A_set == 3 && B_set == 2) || (A_set == 1 && B_set == 3))
                {
                    // A wins the fight
                    A_health -= 25;
                    B_health = 0;

                    A_score += 10 * AB_manhattan_distance + (100 - A_health);

                    A_condition = "Survivor";
                    B_condition = "Defeated";
                    C_condition = "Non-fighter";

                }
                else
                {
                    // B wins the fight
                    B_health -= 25;
                    A_health = 0;

                    B_score += 10 * AB_manhattan_distance + (100 - B_health);

                    A_condition = "Defeated";
                    B_condition = "Survivor";
                    C_condition = "Non-fighter";
                }

            }
            else if (BC_distance < AB_distance && BC_distance < AC_distance)
            {

                // B and C are closest
                if (BC_distance > max_distance)
                {
                    Console.WriteLine("Archers are too far apart. No attacks");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Round 1: B-C");

                if ((B_set == 2 && C_set == 1) || (B_set == 3 && C_set == 2) || (B_set == 1 && C_set == 3))
                {
                    // B wins the fight
                    B_health -= 25;
                    C_health = 0;

                    B_score += 10 * BC_manhattan_distance + (100 - B_health);

                    A_condition = "Non-fighter";
                    B_condition = "Survivor";
                    C_condition = "Defeated";
                }
                else
                {
                    // C wins the fight
                    C_health -= 25;
                    B_health = 0;

                    C_score += 10 * BC_manhattan_distance + (100 - C_health);

                    A_condition = "Non-fighter";
                    B_condition = "Defeated";
                    C_condition = "Survivor";
                }

            }
            else
            {

                // A and C are closest
                if (AC_distance > max_distance)
                {
                    Console.WriteLine("Archers are too far apart. No attacks");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Round 1: A-C");

                if ((A_set == 2 && C_set == 1) || (A_set == 3 && C_set == 2) || (A_set == 1 && C_set == 3))
                {
                    // A wins the fight
                    A_health -= 25;
                    C_health = 0;

                    A_score += 10 * AC_manhattan_distance + (100 - A_health);

                    A_condition = "Survivor";
                    B_condition = "Non-fighter";
                    C_condition = "Defeated";

                }
                else
                {
                    // C wins the fight

                    C_health -= 25;
                    A_health = 0;

                    C_score += 10 * AC_manhattan_distance + (100 - C_health);

                    A_condition = "Defeated";
                    B_condition = "Non-fighter";
                    C_condition = "Survivor";
                }
            }

            // Status of the Archers Result of the Game of Round 1
            Console.Write('\n');
            Console.WriteLine("A: " + A_condition + "  Health: " + A_health + "  Score: " + A_score);
            Console.WriteLine("B: " + B_condition + "  Health: " + B_health + "  Score: " + B_score);
            Console.WriteLine("C: " + C_condition + "  Health: " + C_health + "  Score: " + C_score);
            Console.Write('\n');

            int old_sum_of_healths = A_health + B_health + C_health;

            // Round 2
            // find the defeated player and continue to Round 2

            if (A_health == 0)
            {
                // A is defeated

                // B and C left
                Console.WriteLine("Round 2: B-C");

                if (BC_distance < max_distance)
                {

                    if ((B_set == 2 && C_set == 1) || (B_set == 3 && C_set == 2) || (B_set == 1 && C_set == 3))
                    {
                        // B wins the fight
                        B_health -= 25;
                        C_health = 0;

                        B_score += 10 * BC_manhattan_distance + (100 - B_health);

                        B_condition = "Survivor";
                        C_condition = "Defeated";
                    }
                    else
                    {
                        // C wins the fight
                        C_health -= 25;
                        B_health = 0;

                        C_score += 10 * BC_manhattan_distance + (100 - C_health);

                        B_condition = "Defeated";
                        C_condition = "Survivor";
                    }
                }
            }
            else if (B_health == 0)
            {
                // B is defeated

                // A and C left
                Console.WriteLine("Round 2: A-C");

                if (AC_distance < max_distance)
                {

                    if ((A_set == 2 && C_set == 1) || (A_set == 3 && C_set == 2) || (A_set == 1 && C_set == 3))
                    {
                        // A wins the fight
                        A_health -= 25;
                        C_health = 0;

                        A_score += 10 * AC_manhattan_distance + (100 - A_health);

                        A_condition = "Survivor";
                        C_condition = "Defeated";
                    }
                    else
                    {
                        // C wins the fight
                        C_health -= 25;
                        A_health = 0;

                        C_score += 10 * AC_manhattan_distance + (100 - C_health);

                        A_condition = "Defeated";
                        C_condition = "Survivor";
                    }
                }
            }
            else
            {
                // C is defeated

                // A and B left
                Console.WriteLine("Round 2: A-B");

                if (AB_distance < max_distance)
                {

                    if ((A_set == 2 && B_set == 1) || (A_set == 3 && B_set == 2) || (A_set == 1 && B_set == 3))
                    {
                        // A wins the fight
                        A_health -= 25;
                        B_health = 0;

                        A_score += 10 * AB_manhattan_distance + (100 - A_health);

                        A_condition = "Survivor";
                        B_condition = "Defeated";
                    }
                    else
                    {
                        // B wins the fight
                        B_health -= 25;
                        A_health = 0;

                        B_score += 10 * AB_manhattan_distance + (100 - B_health);

                        A_condition = "Defeated";
                        B_condition = "Survivor";
                    }
                }
            }

            int new_sum_of_healths = A_health + B_health + C_health;

            Console.Write('\n');

            if (old_sum_of_healths > new_sum_of_healths)
            {

                // Status of the Archers Result of the Game of Round 2
                Console.WriteLine("A: " + A_condition + "  Health: " + A_health + "  Score: " + A_score);
                Console.WriteLine("B: " + B_condition + "  Health: " + B_health + "  Score: " + B_score);
                Console.WriteLine("C: " + C_condition + "  Health: " + C_health + "  Score: " + C_score);
            }
            else
            {
                Console.WriteLine("Too distant, no attack");
            }

            Console.Write('\n');

            if (A_score > B_score && A_score > C_score)
            {

                Console.WriteLine("A has the maximum score (" + A_score + ")");
            }
            else if (B_score > A_score && B_score > C_score)
            {

                Console.WriteLine("B has the maximum score (" + B_score + ")");
            }
            else
            {

                Console.WriteLine("C has the maximum score (" + C_score + ")");
            }

            // Syntax: public static void SetCursorposition(int left, int top);
            // Parameters:
            // left: It is the column position of the cursor.
            // Columns are numbered from left to right starting at 0.
            // top: It is the row position of the cursor.
            // Rows are numbered from top to bottom starting at 0.

            var old_color = Console.ForegroundColor;

            if (A_health == 0)
            {
                // A is deafeated
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                // A is survivor
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(26 + Ax * 2, 19 - Ay);
            Console.Write('A');

            if (B_health == 0)
            {
                // B is deafeated
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                // B is survivor
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(26 + Bx * 2, 19 - By);
            Console.Write('B');

            if (C_health == 0)
            {
                // C is deafeated
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                // C is survivor
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(26 + Cx * 2, 19 - Cy);
            Console.Write('C');

            Console.ForegroundColor = old_color;

            // set cursor to its previous location
            Console.SetCursorPosition(0, 46);

            Console.ReadLine();
        }
    }
}
