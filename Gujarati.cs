using System.Collections.Generic;
using System.Linq;

namespace BabySmash
{
    public static class Gujarati
    {
        static Dictionary<int,char> mapping = new Dictionary<int, char> {
            {75,'ક'},{ 1075,'ખ'},
            {71,'ગ'},{ 1071,'ઘ'},
            {67,'ચ'},{ 1067,'છ'},
            {74,'જ'},{ 1074,'ઝ'},
            {84,'ટ'},{ 1084,'ઠ'},
            {68,'ડ'},{ 1068,'ઢ'},
            {78,'ન'},{1078,'ણ'},
            {80,'પ'},{ 1080,'ફ'},
            {66,'બ'},{ 1066,'ભ'},
            {77,'મ'},
            {89,'ય'},
            {82,'ર'},
            {76,'લ'},
            {86,'વ'},{87,'વ'},
            {72,'હ'},{ 1072,'ળ'},
            {83,'સ'},{1083,'શ'},

            //heck mapping since they don't have natural match to any letter
            {65,'ત'}, //A
            {69,'થ'}, //E
            {73,'દ'}, //I
            {79,'ધ'}, //O
            {85,'ષ'}, //U
            {88,'ૐ'}, //X (TODO: wave file is wrong)
            {81,'ઋ'}, //Q (TODO: wave file is wrong)
        };

        public static char Map(bool shift, int virtualKey)
        {
            var lookupKey = shift ?  1000 + virtualKey : virtualKey;

            char charValue;
            var found = mapping.TryGetValue(lookupKey, out charValue);
            return found ? charValue : ' ';
        }

        public static bool IsSupportedChar(char val)
        {
            return mapping.Values.Contains(val);
        }
    }
}
