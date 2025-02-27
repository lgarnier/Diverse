﻿using System.Linq;

namespace Diverse
{
    /// <summary>
    /// Information related to male persons.
    /// </summary>
    public static class Male
    {
        /// <summary>
        /// Gets all the <see cref="ContextualizedFirstName"/> instances possibly used by the lib.
        /// </summary>
        public static ContextualizedFirstName[] ContextualizedFirstNames => _contextualizedFirstNames;

        private static string[] _firstNames = null;

        /// <summary>
        /// Gets all the male first names possibly used by the lib.
        /// </summary>
        public static string[] FirstNames
        {
            get
            {
                if (_firstNames == null)
                {
                    _firstNames =  Male.ContextualizedFirstNames
                                            .Where(x => !string.IsNullOrWhiteSpace(x.FirstName))
                                            .Select(m => m.FirstName)
                                            .Distinct()
                                            .ToArray();
                }

                return _firstNames;
            }
        }

        private static readonly ContextualizedFirstName[] _contextualizedFirstNames = new ContextualizedFirstName[]
        {
            new ContextualizedFirstName("Moussa", Continent.Africa),
            new ContextualizedFirstName("Djibril", Continent.Africa),
            new ContextualizedFirstName("Issa", Continent.Africa),
            new ContextualizedFirstName("Sékou", Continent.Africa),
            new ContextualizedFirstName("Djiby", Continent.Africa),
            new ContextualizedFirstName("Koffi", Continent.Africa),
            new ContextualizedFirstName("Mahdi", Continent.Africa),
            new ContextualizedFirstName("Demba", Continent.Africa),
            new ContextualizedFirstName("Mamadou", Continent.Africa),
            new ContextualizedFirstName("Atef", Continent.Africa),
            new ContextualizedFirstName("Ousmane", Continent.Africa),
            new ContextualizedFirstName("Ladji", Continent.Africa),
            new ContextualizedFirstName("Aly-Bocar", Continent.Africa),
            new ContextualizedFirstName("Uélé", Continent.Africa),
            new ContextualizedFirstName("Kinfe", Continent.Africa),
            new ContextualizedFirstName("Mugisa", Continent.Africa),
            new ContextualizedFirstName("Kimoni", Continent.Africa),
            new ContextualizedFirstName("Simba", Continent.Africa),
            new ContextualizedFirstName("Kwanza", Continent.Africa),
            new ContextualizedFirstName("Olamide", Continent.Africa),
            new ContextualizedFirstName("Bahari", Continent.Africa),
            new ContextualizedFirstName("Dzigbode", Continent.Africa),
            new ContextualizedFirstName("Sekou", Continent.Africa),
            new ContextualizedFirstName("Dakarai", Continent.Africa),
            new ContextualizedFirstName("Nuru", Continent.Africa),
            new ContextualizedFirstName("Okal", Continent.Africa),
            new ContextualizedFirstName("Sadioba", Continent.Africa),
            new ContextualizedFirstName("Thierno", Continent.Africa),
            new ContextualizedFirstName("Cheikh", Continent.Africa),
            new ContextualizedFirstName("Babacar", Continent.Africa),
            new ContextualizedFirstName("Aliou", Continent.Africa),
            new ContextualizedFirstName("Adama", Continent.Africa),
            new ContextualizedFirstName("Malik", Continent.Africa),
            new ContextualizedFirstName("Lamine", Continent.Africa),
            
            new ContextualizedFirstName("Yazid", Continent.Africa),
            new ContextualizedFirstName("Ali", Continent.Africa),
            new ContextualizedFirstName("Karim", Continent.Africa),
            new ContextualizedFirstName("Mohammed", Continent.Africa),
            new ContextualizedFirstName("Mehdi", Continent.Africa),
            new ContextualizedFirstName("Noam", Continent.Africa),
            new ContextualizedFirstName("Jalil", Continent.Africa),
            new ContextualizedFirstName("Malik", Continent.Africa),
            new ContextualizedFirstName("Hakim", Continent.Africa),
            new ContextualizedFirstName("Hisham", Continent.Africa),
            new ContextualizedFirstName("Abdourahmane", Continent.Africa),
            new ContextualizedFirstName("Youssef", Continent.Africa),
            new ContextualizedFirstName("Lounes", Continent.Africa),
            new ContextualizedFirstName("Khaled", Continent.Africa),
            new ContextualizedFirstName("Lahcen", Continent.Africa),
            new ContextualizedFirstName("Sadiq", Continent.Africa),
            new ContextualizedFirstName("Akmal", Continent.Africa),
            new ContextualizedFirstName("Jemahl", Continent.Africa),
            new ContextualizedFirstName("Abu Bakr", Continent.Africa),
            new ContextualizedFirstName("Waleed", Continent.Africa),
            new ContextualizedFirstName("Jemaal", Continent.Africa),
            new ContextualizedFirstName("Adil", Continent.Africa),
            new ContextualizedFirstName("Naseer", Continent.Africa),
            new ContextualizedFirstName("Abdallah", Continent.Africa),

            new ContextualizedFirstName("Aleksander", Continent.Antarctica),
            new ContextualizedFirstName("Ansgar", Continent.Antarctica),
            new ContextualizedFirstName("Einar", Continent.Antarctica),
            new ContextualizedFirstName("Casper", Continent.Antarctica),
            new ContextualizedFirstName("Eirik", Continent.Antarctica),
            new ContextualizedFirstName("Enok", Continent.Antarctica),
            new ContextualizedFirstName("Espen", Continent.Antarctica),
            new ContextualizedFirstName("Frans", Continent.Antarctica),
            new ContextualizedFirstName("Gjurd", Continent.Antarctica),
            new ContextualizedFirstName("Gunne", Continent.Antarctica),
            new ContextualizedFirstName("Olle", Continent.Antarctica),
            new ContextualizedFirstName("Oluf", Continent.Antarctica),
            new ContextualizedFirstName("Bjorn", Continent.Antarctica),
            new ContextualizedFirstName("Hjalmer", Continent.Antarctica),
            new ContextualizedFirstName("Kris", Continent.Antarctica),
            new ContextualizedFirstName("Gustavus", Continent.Antarctica),
            new ContextualizedFirstName("Sven", Continent.Antarctica),
            new ContextualizedFirstName("Skeet", Continent.Antarctica),
            new ContextualizedFirstName("Heimdall", Continent.Antarctica),
            new ContextualizedFirstName("Osmunde", Continent.Antarctica),
            new ContextualizedFirstName("Jensson", Continent.Antarctica),
            new ContextualizedFirstName("Ragnar", Continent.Antarctica),
            new ContextualizedFirstName("Hallverd", Continent.Antarctica),
            new ContextualizedFirstName("Vondell", Continent.Antarctica),
            new ContextualizedFirstName("Eyulf", Continent.Antarctica),
            new ContextualizedFirstName("Hagan", Continent.Antarctica),
            new ContextualizedFirstName("Eskel", Continent.Antarctica),
            new ContextualizedFirstName("Tuve", Continent.Antarctica),
            
            new ContextualizedFirstName("Yi", Continent.Asia),
            new ContextualizedFirstName("Jian", Continent.Asia),
            new ContextualizedFirstName("Jin", Continent.Asia),
            new ContextualizedFirstName("Cheng", Continent.Asia),
            new ContextualizedFirstName("Tian", Continent.Asia),
            new ContextualizedFirstName("Zhen", Continent.Asia),
            new ContextualizedFirstName("Chao", Continent.Asia),
            new ContextualizedFirstName("Guang", Continent.Asia),
            new ContextualizedFirstName("Yu Jie", Continent.Asia),
            new ContextualizedFirstName("Shui", Continent.Asia),
            new ContextualizedFirstName("Qiao", Continent.Asia),
            new ContextualizedFirstName("Tao", Continent.Asia),
            new ContextualizedFirstName("Shing", Continent.Asia),
            new ContextualizedFirstName("Mu", Continent.Asia),
            new ContextualizedFirstName("Xing Xing", Continent.Asia),

            new ContextualizedFirstName("Ba-Thong", Continent.Asia),
            new ContextualizedFirstName("Hoàng", Continent.Asia),
            new ContextualizedFirstName("Bao", Continent.Asia),
            new ContextualizedFirstName("Hoà", Continent.Asia),
            new ContextualizedFirstName("Quang", Continent.Asia),
            new ContextualizedFirstName("Toàn", Continent.Asia),
            new ContextualizedFirstName("Vinh", Continent.Asia),
            new ContextualizedFirstName("Khoi", Continent.Asia),
            new ContextualizedFirstName("Thuyet", Continent.Asia),
            new ContextualizedFirstName("Trung", Continent.Asia),
            new ContextualizedFirstName("Binh", Continent.Asia),
            new ContextualizedFirstName("Loc", Continent.Asia),

            new ContextualizedFirstName("Kim", Continent.Asia),
            new ContextualizedFirstName("Kwon", Continent.Asia),
            new ContextualizedFirstName("Hwang", Continent.Asia),
            
            new ContextualizedFirstName("Daichi", Continent.Asia),
            new ContextualizedFirstName("Akira", Continent.Asia),
            new ContextualizedFirstName("Daisuke", Continent.Asia),
            new ContextualizedFirstName("Fumihiro", Continent.Asia),
            new ContextualizedFirstName("Hikaru", Continent.Asia),
            new ContextualizedFirstName("Hansuke", Continent.Asia),
            new ContextualizedFirstName("Soske", Continent.Asia),
            new ContextualizedFirstName("Kōhei", Continent.Asia),
            new ContextualizedFirstName("Izuku", Continent.Asia),
            new ContextualizedFirstName("Katsuki", Continent.Asia),

            new ContextualizedFirstName("Mentari", Continent.Asia),
            new ContextualizedFirstName("Timur", Continent.Asia),
            new ContextualizedFirstName("Eko", Continent.Asia),
            new ContextualizedFirstName("Gemi", Continent.Asia),
            new ContextualizedFirstName("Harta", Continent.Asia),

            new ContextualizedFirstName("Aslan", Continent.Asia),
            new ContextualizedFirstName("Eren", Continent.Asia),
            new ContextualizedFirstName("Enis", Continent.Asia),
            new ContextualizedFirstName("Kaan", Continent.Asia),
            new ContextualizedFirstName("Aylan", Continent.Asia),
            new ContextualizedFirstName("Mehmet", Continent.Asia),
            new ContextualizedFirstName("Ömer", Continent.Asia),
            new ContextualizedFirstName("Abraham", Continent.Asia),
            new ContextualizedFirstName("Elias", Continent.Asia),
            new ContextualizedFirstName("Nataniel", Continent.Asia),
            new ContextualizedFirstName("Joab", Continent.Asia),
            new ContextualizedFirstName("Davy", Continent.Asia),
            new ContextualizedFirstName("Davyd", Continent.Asia),
            new ContextualizedFirstName("Daneal", Continent.Asia),
            new ContextualizedFirstName("Shoval", Continent.Asia),
            new ContextualizedFirstName("Jarrad", Continent.Asia),
            new ContextualizedFirstName("Jarrad", Continent.Asia),
            new ContextualizedFirstName("Yannick", Continent.Asia),

            new ContextualizedFirstName("Kumar", Continent.Asia),
            new ContextualizedFirstName("Arjun", Continent.Asia),
            new ContextualizedFirstName("Aadesh", Continent.Asia),
            new ContextualizedFirstName("Abhimanyu", Continent.Asia),
            new ContextualizedFirstName("Adrith", Continent.Asia),
            new ContextualizedFirstName("Akshay", Continent.Asia),
            new ContextualizedFirstName("Kamal", Continent.Asia),
            new ContextualizedFirstName("Lavish", Continent.Asia),
            new ContextualizedFirstName("Krishna", Continent.Asia),
            new ContextualizedFirstName("Rajiv", Continent.Asia),
            new ContextualizedFirstName("Sumedh", Continent.Asia),
            new ContextualizedFirstName("Jaycarran", Continent.Asia),
            new ContextualizedFirstName("Ashok", Continent.Asia),
            new ContextualizedFirstName("Shivedutt", Continent.Asia),
            new ContextualizedFirstName("Mahavira", Continent.Asia),
            new ContextualizedFirstName("Saariq", Continent.Asia),
            new ContextualizedFirstName("Umed", Continent.Asia),
            new ContextualizedFirstName("Sareek", Continent.Asia),
            new ContextualizedFirstName("Nirav", Continent.Asia),
            new ContextualizedFirstName("Ashvik", Continent.Asia),
            new ContextualizedFirstName("Ganesa", Continent.Asia),
            new ContextualizedFirstName("Ranjit", Continent.Asia),
            new ContextualizedFirstName("Sanjay", Continent.Asia),
            new ContextualizedFirstName("Govind", Continent.Asia),

            new ContextualizedFirstName("Achille", Continent.Europe),
            new ContextualizedFirstName("Markus", Continent.Europe),
            new ContextualizedFirstName("Wolfgang", Continent.Europe),
            new ContextualizedFirstName("Lukas", Continent.Europe),
            new ContextualizedFirstName("Karl", Continent.Europe),
            new ContextualizedFirstName("Edouard", Continent.Europe),
            new ContextualizedFirstName("Jean-Pierre", Continent.Europe),
            new ContextualizedFirstName("Dimitri", Continent.Europe),
            new ContextualizedFirstName("Jeremie", Continent.Europe),
            new ContextualizedFirstName("Louis", Continent.Europe),
            new ContextualizedFirstName("Thomas", Continent.Europe),
            new ContextualizedFirstName("Dimitri", Continent.Europe),
            new ContextualizedFirstName("Silvin", Continent.Europe),
            new ContextualizedFirstName("Jérôme", Continent.Europe),
            new ContextualizedFirstName("Guillaume", Continent.Europe),
            
            new ContextualizedFirstName("Julien", Continent.Europe),
            new ContextualizedFirstName("Bruno", Continent.Europe),
            new ContextualizedFirstName("Sacha", Continent.Europe),
            new ContextualizedFirstName("Anton", Continent.Europe),
            new ContextualizedFirstName("Vadim", Continent.Europe),
            new ContextualizedFirstName("Maxime", Continent.Europe),
            new ContextualizedFirstName("Mikhail", Continent.Europe),
            new ContextualizedFirstName("Alexei", Continent.Europe),
            new ContextualizedFirstName("Samuel", Continent.Europe),
            new ContextualizedFirstName("Didier", Continent.Europe),
            
            new ContextualizedFirstName("Igor", Continent.Europe),
            new ContextualizedFirstName("Ruslan", Continent.Europe),
            new ContextualizedFirstName("Evgeniy", Continent.Europe),
            new ContextualizedFirstName("Anatoliy", Continent.Europe),
            new ContextualizedFirstName("Yuri", Continent.Europe),
            new ContextualizedFirstName("Mischa", Continent.Europe),
            new ContextualizedFirstName("Sacha", Continent.Europe),
            new ContextualizedFirstName("Dmitriy", Continent.Europe),
            new ContextualizedFirstName("Yevgeniy", Continent.Europe),
            new ContextualizedFirstName("Liev", Continent.Europe),
            
            new ContextualizedFirstName("Gianny", Continent.Europe),
            new ContextualizedFirstName("Lucca", Continent.Europe),
            new ContextualizedFirstName("Marco", Continent.Europe),
            new ContextualizedFirstName("Giovanni", Continent.Europe),
            new ContextualizedFirstName("Enzo", Continent.Europe),
            new ContextualizedFirstName("Vinicio", Continent.Europe),
            new ContextualizedFirstName("Milo", Continent.Europe),
            new ContextualizedFirstName("Guido", Continent.Europe),
            new ContextualizedFirstName("Calogero", Continent.Europe),
            new ContextualizedFirstName("Gianni", Continent.Europe),
            new ContextualizedFirstName("Matteo", Continent.Europe),
            new ContextualizedFirstName("Alessandro", Continent.Europe),
            
            new ContextualizedFirstName("Milen", Continent.Europe),
            new ContextualizedFirstName("Yavor", Continent.Europe),
            new ContextualizedFirstName("Stoyan", Continent.Europe),
            new ContextualizedFirstName("Boyko", Continent.Europe),
            new ContextualizedFirstName("Bojan", Continent.Europe),
            new ContextualizedFirstName("Gojko", Continent.Europe),
            new ContextualizedFirstName("Stefan", Continent.Europe),
            
            new ContextualizedFirstName("Enrico", Continent.Europe),
            new ContextualizedFirstName("Frederico", Continent.Europe),
            new ContextualizedFirstName("Arsene", Continent.Europe),
            new ContextualizedFirstName("Alohnzo", Continent.Europe),
            new ContextualizedFirstName("Ramone", Continent.Europe),
            new ContextualizedFirstName("Pietro", Continent.Europe),
            new ContextualizedFirstName("Javi", Continent.Europe),
            
            new ContextualizedFirstName("Sonny", Continent.NorthAmerica),
            new ContextualizedFirstName("Barack", Continent.NorthAmerica),
            new ContextualizedFirstName("David", Continent.NorthAmerica),
            new ContextualizedFirstName("Kevin", Continent.NorthAmerica),
            new ContextualizedFirstName("John", Continent.NorthAmerica),
            new ContextualizedFirstName("Jacob", Continent.NorthAmerica),
            new ContextualizedFirstName("Liam", Continent.NorthAmerica),
            new ContextualizedFirstName("Sean", Continent.NorthAmerica),
            new ContextualizedFirstName("Connor", Continent.NorthAmerica),
            new ContextualizedFirstName("James", Continent.NorthAmerica),
            new ContextualizedFirstName("George", Continent.NorthAmerica),
            new ContextualizedFirstName("Glenn", Continent.NorthAmerica),
            new ContextualizedFirstName("Matthew", Continent.NorthAmerica),
            new ContextualizedFirstName("Jerry", Continent.NorthAmerica),
            new ContextualizedFirstName("Mitt", Continent.NorthAmerica),
            new ContextualizedFirstName("Milton", Continent.NorthAmerica),
            new ContextualizedFirstName("Jorrel", Continent.NorthAmerica),
            new ContextualizedFirstName("Meryle", Continent.NorthAmerica),
            new ContextualizedFirstName("Karson", Continent.NorthAmerica),
            new ContextualizedFirstName("Dayshaun", Continent.NorthAmerica),
            new ContextualizedFirstName("Shaquile", Continent.NorthAmerica),
            new ContextualizedFirstName("Jarmaine", Continent.NorthAmerica),
            new ContextualizedFirstName("Rhody", Continent.NorthAmerica),
            new ContextualizedFirstName("Dwade", Continent.NorthAmerica),
            new ContextualizedFirstName("Podrick", Continent.NorthAmerica),
            new ContextualizedFirstName("Teal", Continent.NorthAmerica),
            new ContextualizedFirstName("Dejon", Continent.NorthAmerica),
            new ContextualizedFirstName("D’Amico", Continent.NorthAmerica),
            new ContextualizedFirstName("Davon", Continent.NorthAmerica),
            new ContextualizedFirstName("Lavar", Continent.NorthAmerica),
            new ContextualizedFirstName("Marv", Continent.NorthAmerica),
            new ContextualizedFirstName("Melvin", Continent.NorthAmerica),
            new ContextualizedFirstName("Latrell", Continent.NorthAmerica),
            new ContextualizedFirstName("Dylan", Continent.NorthAmerica),
            new ContextualizedFirstName("Deion", Continent.NorthAmerica),
            new ContextualizedFirstName("Jaycee", Continent.NorthAmerica),
            new ContextualizedFirstName("Darrence", Continent.NorthAmerica),

            new ContextualizedFirstName("Adriano", Continent.SouthAmerica),
            new ContextualizedFirstName("Alejandro", Continent.SouthAmerica),
            new ContextualizedFirstName("Alberto", Continent.SouthAmerica),
            new ContextualizedFirstName("Alberto", Continent.SouthAmerica),
            new ContextualizedFirstName("Esteban", Continent.SouthAmerica),
            new ContextualizedFirstName("Abraão", Continent.SouthAmerica),
            new ContextualizedFirstName("Alfonso", Continent.SouthAmerica),
            new ContextualizedFirstName("Javier", Continent.SouthAmerica),
            new ContextualizedFirstName("Angel", Continent.SouthAmerica),
            new ContextualizedFirstName("Sergio", Continent.SouthAmerica),
            new ContextualizedFirstName("Diego", Continent.SouthAmerica),
            new ContextualizedFirstName("Hernán", Continent.SouthAmerica),
            new ContextualizedFirstName("Héctor", Continent.SouthAmerica),
            new ContextualizedFirstName("Jesús", Continent.SouthAmerica),
            new ContextualizedFirstName("Carlos", Continent.SouthAmerica),
            new ContextualizedFirstName("Cruz", Continent.SouthAmerica),
            new ContextualizedFirstName("Junipero", Continent.SouthAmerica),
            new ContextualizedFirstName("Ricardo", Continent.SouthAmerica),
            new ContextualizedFirstName("Cruzito", Continent.SouthAmerica),
            new ContextualizedFirstName("Atahualpa", Continent.SouthAmerica),
            new ContextualizedFirstName("João", Continent.SouthAmerica),
            new ContextualizedFirstName("Antônio", Continent.SouthAmerica),
            new ContextualizedFirstName("Augusto", Continent.SouthAmerica),
            new ContextualizedFirstName("Benício", Continent.SouthAmerica),
            new ContextualizedFirstName("Bento", Continent.SouthAmerica),
            new ContextualizedFirstName("Bruno", Continent.SouthAmerica),
            new ContextualizedFirstName("Caio", Continent.SouthAmerica),
            new ContextualizedFirstName("César", Continent.SouthAmerica),

            new ContextualizedFirstName("Jomdah", Continent.Australia),
            new ContextualizedFirstName("Mallinbilly", Continent.Australia),
            new ContextualizedFirstName("Bilaranora", Continent.Australia),
            new ContextualizedFirstName("Naibar", Continent.Australia),
            new ContextualizedFirstName("Guemajarry", Continent.Australia),
            new ContextualizedFirstName("Linjah", Continent.Australia),
            new ContextualizedFirstName("Drell", Continent.Australia),
            new ContextualizedFirstName("Kaawa", Continent.Australia),
            new ContextualizedFirstName("Yarran", Continent.Australia),
            new ContextualizedFirstName("Isley", Continent.Australia),
            new ContextualizedFirstName("Omeo", Continent.Australia),
            new ContextualizedFirstName("Thono", Continent.Australia),
            new ContextualizedFirstName("Kinta", Continent.Australia),
            new ContextualizedFirstName("Paratyl", Continent.Australia),
            new ContextualizedFirstName("Teangi", Continent.Australia),
            new ContextualizedFirstName("Noah", Continent.Australia),
            new ContextualizedFirstName("William", Continent.Australia),
            new ContextualizedFirstName("Josh", Continent.Australia),
            new ContextualizedFirstName("Jack", Continent.Australia),
            new ContextualizedFirstName("Ethan", Continent.Australia),
            new ContextualizedFirstName("Mason", Continent.Australia),
            new ContextualizedFirstName("Harrison", Continent.Australia),
            new ContextualizedFirstName("Elijah", Continent.Australia),
            new ContextualizedFirstName("Hudson", Continent.Australia),
            new ContextualizedFirstName("Cooper", Continent.Australia),
            new ContextualizedFirstName("Logan", Continent.Australia),
            new ContextualizedFirstName("Archer", Continent.Australia),
            new ContextualizedFirstName("Riley", Continent.Australia),

            new ContextualizedFirstName("Gidja", Continent.Australia),
            new ContextualizedFirstName("Vaea", Continent.Australia),
            new ContextualizedFirstName("Temoe", Continent.Australia),
            new ContextualizedFirstName("Manua", Continent.Australia),
            new ContextualizedFirstName("Teiki", Continent.Australia),
            new ContextualizedFirstName("Rahiti", Continent.Australia),
            new ContextualizedFirstName("Aata", Continent.Australia),
            new ContextualizedFirstName("Heimanu", Continent.Australia),
        };
    }
}