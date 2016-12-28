using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordChecker
{
    class WordChecker
    {
        private string master = string.Empty;
        private string compare = string.Empty;
        private string results = string.Empty;
        private double score = 0;
        private string[] mArray;
        private string[] cArray;
        private char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 
                                'g', 'h', 'i', 'j', 'k', 'l', 
                                'm', 'n', 'o', 'p', 'q', 'r', 
                                's', 't', 'u', 'v', 'w', 'x', 
                                'y', 'z', ' '};
        
        public string Master
        {
            get { return master; }
            set { master = value; }
        }

        public string Compare
        {
            get { return compare; }
            set { compare = value; }
        }

        public string Results
        {
            get { return results; }
        }

        public WordChecker()
        {
        }

        public WordChecker(string m, string c)
        {
            master = m;
            compare = c;
        }

        //Strips away all but spaces and letters
        public string RemovePunctuation(string word)
        {
            string stripped = string.Empty;
            int count = 0;

            count = word.Length;
            for (int i = 0; i < count; i++)
            {
                if (LetterCheck(char.ToLower(word[i])))
                {
                    if (i == '-')
                        stripped += " ";
                    else
                        stripped += word[i];
                }
            }
            return stripped;
        }

        //Compare string in current order
        public double CompareWords(string m, string c)
        {
            m = m.ToLower();
            c = c.ToLower();
            int match = 0;
            int total = m.Length;

            if (m.Length > c.Length)
                if (m.IndexOf(c) != -1)
                    match = c.Length;
            if (m.Length < c.Length)
                if (c.IndexOf(m) != -1)
                {
                    match = m.Length;
                    total = c.Length;
                }
            if (m.Length == c.Length)
            {
                for (int i = 0; i < m.Length; i++)
                {
                    if (m[i] == c[i])
                        match++;
                }
            }
            if (match != 0)
                score = (double)match / (double)total;
            else
                score = 0;
            return score;
        }

        //Verifies valid characters
        private bool LetterCheck(char p)
        {
            bool isLetter = false;

            if (Array.IndexOf(alphabet, p) > -1)
                isLetter = true;

            return isLetter;
        }

        //Compare all letters in any order
        public double CompareAllLetters(string m, string c)
        {
            m = m.ToLower();
            c = c.ToLower();
            
            int[,] letterCount = new int[2,alphabet.Count()];
            double count = 0;

            foreach (char l in m)
	        {
                if(Array.IndexOf(alphabet, l) != -1)
                    letterCount[0, Array.IndexOf(alphabet, l)]++;
	        }
            foreach (char l in c)
	        {
                if(Array.IndexOf(alphabet, l) != -1)
                    letterCount[1, Array.IndexOf(alphabet, l)]++;
	        }

            for (int i = 0; i < letterCount.GetLength(1); i++)
			{
                if (letterCount[0, i] > 0)
                {
                    if (letterCount[0, i] == letterCount[1, i] ||
                        letterCount[0, i] < letterCount[1, i])
                        count += letterCount[0, i];
                    else /*(letterCount[0, i] > letterCount[1, i])*/
                        count += letterCount[1, i];
                }
			}
            if (m.Length < c.Length)
                score = count / (double)c.Length;
            else
                score = count / (double)m.Length;

            return score;
        }

        //Compares two strings, broken apart my spaces
        public double CompleteCheck(string m, string c)
        {
            m = m.ToLower();
            c = c.ToLower();
            m = RemovePunctuation(m);
            c = RemovePunctuation(c);
            mArray = m.Split(' ');
            cArray = c.Split(' ');
            double[,] scoreArray = new double[2, mArray.Length];
            int[] used = new int[cArray.Length];
            double totalScore = 0;
            results = string.Empty;

            for (int u = 0; u < used.Count(); u++)
            {
                used[u] = -1;
            }

            //Cycles through both arrays
            for (int z = 0; z < mArray.Length; z++)
            {
                //Debug code
                results += "LOOP " + z.ToString() + Environment.NewLine;

                for (int masterWord = 0; masterWord < mArray.Length; masterWord++)
                {
                    for (int compareWord = 0; compareWord < cArray.Length; compareWord++)
                    {
                        if (used[compareWord] < 0)
                        {
                            //Calls to compare both words as is
                            score = CompareWords(mArray[masterWord], cArray[compareWord]);

                            //Debug code
                            results += "Compare Word: " + mArray[masterWord] + " " + cArray[compareWord] +
                                       " score - " + score.ToString("P0") + Environment.NewLine;

                            //If not perfect match checks totallity of the letters
                            if (score < 1)
                            {
                                double tempScore = score;
                                CompareAllLetters(mArray[masterWord], cArray[compareWord]);

                                //Debug code
                                results += "Compare Letters: " + mArray[masterWord] + " " + cArray[compareWord] +
                                       " score - " + score.ToString("P0") + Environment.NewLine;

                                if (tempScore > 0)
                                    score = (score + tempScore) / 2.0;
                            }

                            //Checks score to find best match
                            if (score > scoreArray[0, masterWord])
                            {
                                scoreArray[0, masterWord] = score;
                                scoreArray[1, masterWord] = (double)compareWord;
                                used[compareWord] = masterWord;

                                //Debug code
                                results += cArray[compareWord] + " marked used." + Environment.NewLine;
                                while (Array.IndexOf(used, masterWord) != Array.LastIndexOf(used, masterWord))
                                {
                                    used[Array.IndexOf(used, masterWord)] = -1;
                                    results += cArray[(int)scoreArray[1, compareWord]] + " marked unused.1" + Environment.NewLine;
                                }
                            }

                            //If score matches checks to see which word is closer to size of master
                            if (score == scoreArray[0, masterWord] && score != 0
                                /*|| score > scoreArray[0, masterWord] && score !=0*/)
                            {
                                double current;
                                double stored;
                                current = Math.Abs(mArray[masterWord].Length - cArray[compareWord].Length);
                                stored = Math.Abs(mArray[masterWord].Length - cArray[(int)scoreArray[1, compareWord]].Length);

                                if (current < stored)
                                {
                                    used[(int)scoreArray[1, masterWord]] = -1;

                                    //Debug code
                                    results += cArray[(int)scoreArray[1, compareWord]] + " marked unused.2" + Environment.NewLine;

                                    scoreArray[1, masterWord] = (double)compareWord;
                                    scoreArray[0, (int)scoreArray[1, masterWord]] = 0;
                                    scoreArray[1, (int)scoreArray[1, masterWord]] = 0;
                                }
                            }
                        }
                    } 
                }
            }
            //Cycles through master array showing what word it matched and its score
            for (int s = 0; s < mArray.Length; s++)
            {
                totalScore += scoreArray[0, s];
                results += mArray[s] + " " + scoreArray[0, s].ToString("P0") + " matched to ";
                //Fix for making sure if no score and default word doesn't count
                if (scoreArray[0, s] == 0.0 && scoreArray[1, s] == 0.0)
                    results += "N/A";
                else
                    results += cArray[(int)scoreArray[1, s]];
                results += Environment.NewLine;
            }
            totalScore /= (double)mArray.Length;

            return totalScore;
        }
    }
}
