using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CreateFixture : fixture
    {
        private ArrayList observers;
        maclar fix;
        public CreateFixture()
        {
            observers = new ArrayList();
            fix = new maclar();
        }
        
        public void notifyObservers() { 
        
            foreach(Observer o in observers)
		    {
			    o.fixUpdate(fix);
		    }
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void olustur(int teamN, int[] takimID,string fixLig, int[] salonID)
        {
            
            int teams = teamN;
            // Generate the fixtures using the cyclic algorithm.
            int totalRounds = teams - 1;
            int matchesPerRound = teams / 2;
            // When creating an array of arrays the last rank is left
            // empty because you need to create each row with a new
            // array with possible different sizes.
            String[][] rounds = new String[totalRounds][];
            for (int round = 0; round < totalRounds; round++)
                rounds[round] = new String[matchesPerRound];
       
            for (int round = 0; round < totalRounds; round++)
            {
                for (int match = 0; match < matchesPerRound; match++)
                {
                    try
                    {
                        int home = (round + match) % (teams - 1);
                        int away = (teams - 1 - match + round) % (teams - 1);
                        // Last team stays in the same place while the others
                        // rotate around it.
                        if (match == 0) {
                            away = teams - 1;
                        }
                        // Add one so teams are number 1 to teams not 0 to teams - 1 upon display.
                        //rounds[round][match] = (home + 1) + " v " + (away + 1);
                        fix.homeID = takimID[home];
                        fix.awayID = takimID[away];
                        fix.hafta = round + 1;
                        fix.ligAdi = fixLig;
                        fix.salonID = salonID[home];
                        fixtureChanged();                        
                        
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                        System.Environment.Exit(1);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        System.Environment.Exit(1);
                    }
                }
            }
        }
        public void fixtureChanged()
        {
            notifyObservers();
        }
    }
}