﻿using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Algorithms;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace UnitTest
{
    class Program
    {

        static void Main(string[] args)
        {
            BacktrackProlems test = new BacktrackProlems();
            DynamicProgramming DP = new DynamicProgramming();
            BinarySearch test4 = new BinarySearch();
            ArrayProblems APS = new ArrayProblems();
            StringProblems SP = new StringProblems();
            LinkListProblems LLP = new LinkListProblems();
            BinaryTree BT = new BinaryTree();
            ParallelProblems pp = new ParallelProblems();
            // Console.WriteLine("---1.ArrayProblems---");
            // int[] newArr = { -1, 0, 1, 2, -1, -4 };
            // var result = test1.ThreeSum(newArr);
            // Console.WriteLine(ArrayProblems.toString(result));
            // int[] newArr2 = { 2, 1, 0, -1 };
            // var result2 = test.FourSum(newArr2, 2);
            // Console.WriteLine(ArrayProblems.toString(result2));
            // Console.WriteLine("---2.DynamicProgramming---");
            // int[] newArr3 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            // var result3 = test2.MaxSubArraySum(newArr3);
            // Console.WriteLine(result3);
            // var result4 = test2.climbStair(60);
            // Console.WriteLine(result4);
            // int[] newArr5 = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            // var result5 = test2.MinCostClimbingStairs(newArr5);
            // Console.WriteLine(result5);
            // int[][] newArr6 = new int[][] { new int[2] { 1, 3 }, new int[2] { 2, 6 }, new int[2] { 8, 10 }, new int[2] { 15, 18 } };
            // var result6 = test.mergeIntervals(newArr6);
            // Console.WriteLine(ArrayProblems.toString(result6));
            // int[] newArr7 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            // var result7 = test2.MaxSeqSubArray(newArr7);
            // Console.WriteLine(result7);
            // int[] newArr8 = { 1, 2, 3 };
            // Console.WriteLine(ArrayProblems.toString(test.Permute(newArr8)));
            //test.CombinationSum3(2, 18);
            //int[] newArr9 = { 1, 2, 2 };
            //test.SubsetsWithDup(newArr9);
            //test.GetPermutation(9, 273815);
            //a=a^b b=b^a^b=a a=a^b^a=b
            int[] newArr16 = { -1, 2, 1, -4 };
            var result16 = APS.ThreeSumClosest(newArr16, 1);
            Console.WriteLine(result16);
            int[] newArr31 = { 4, 3, 2, 1 };
            APS.NextPermutation(newArr31);
            int[] newArrtest = { 2, 3, 1 };
            Console.WriteLine(APS.cantorExpansion(newArrtest));
            APS.deCantorExpansion(5, 96);
            int[][] newArr64 = { new int[] { 1, 2, 5 }, new int[] { 3, 2, 1 } };
            Console.WriteLine(DP.MinPathSum(newArr64));
            int[] newArr229 = { 2, 2, 9, 3, 9, 3, 9, 3, 9, 3, 9, 3, 9, 3, 9, 3, 9 };
            Console.WriteLine(APS.MajorityElement(newArr229));
            Console.WriteLine("UniquePaths:" + DP.UniquePaths(7, 3));
            int[] newArr137 = { 2, 2, 2, 3, 1, 5, 1, 1, 5, 5 };
            Console.WriteLine(APS.SingleNumber(newArr137));
            int[] newArr209 = { 5, 1, 3, 5, 10, 7, 4, 9, 2, 8, 15 };
            Console.WriteLine(APS.MinSubArrayLen(15, newArr209));
            //[[0,1,0,0,0],[1,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
            int[][] newArr63 = { new int[] { 0, 1, 0, 0, 0 }, new int[] { 1, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 } };
            Console.WriteLine("UniquePathsWithObstacles:" + DP.UniquePathsWithObstacles(newArr63));
            int[] newArr152 = { 2, -2, 3, 4 };
            Console.WriteLine("MaxProduct:" + DP.MaxProduct(newArr152));
            int[] newArr300 = { 1, 5, 2, 6, 3, 7, 4 };
            Console.WriteLine("LengthOfLIS:" + DP.LengthOfLIS(newArr300));
            int[][] newArr120 = { new int[] { 2 }, new int[] { 3, 4 }, new int[] { 6, 5, 7 }, new int[] { 4, 1, 8, 3 } };
            Console.WriteLine("MinimumTotal:" + DP.MinimumTotal(newArr120));
            char[][] newArr221 = { new char[] { '1', '0', '1', '0', '0' }, new char[] { '1', '0', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1' }, new char[] { '1', '0', '0', '1', '0' } };
            Console.WriteLine("MaximalSquare:" + DP.MaximalSquare(newArr221));
            int[] Arr33 = { 2, 5, 6, 0, 0, 1, 2 };
            Console.WriteLine("RotatedSortArrayI:" + test4.RotatedSortArrayI(Arr33, 0));
            int[] Arr81 = { 1, 3, 1, 1, 1, 1 };
            Console.WriteLine("RotatedSortArrayII:" + test4.RotatedSortArrayII(Arr81, 3));
            int[] Arr162 = { 3, 2, 1 };
            Console.WriteLine("FindPeakElement:" + test4.FindPeakElement(Arr162));
            int[] Arr153 = { 4, 5, 1, 2, 3 };
            Console.WriteLine("FindMin:" + test4.FindMin(Arr153));
            int[] Arr154 = { 4, 4, 5, 5, 1, 2, 3, 3 };
            Console.WriteLine("FindMinII:" + test4.FindMinII(Arr154));
            //[279. Perfect Squares]
            Console.WriteLine("279. Perfect Squares:" + DP.NumSquares(43));
            int[][] newArr48 = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            Console.WriteLine(ArrayProblems.toString(newArr48));
            APS.Rotate(newArr48);
            Console.WriteLine("48. Rotated:" + ArrayProblems.toString(newArr48));
            string[] Arr49 = { "eat", "tea", "tan", "ate", "nat", "bat" };
            Console.WriteLine("48. Rotated:" + SP.GroupAnagrams(Arr49));
            Console.WriteLine("264. Ugly Number II:" + DP.NthUglyNumber(10));

            int[] newArr11 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine("11. Container With Most Water:" + APS.MaxArea(newArr11));
            int[] newArr228 = { 0, 1, 2, 4, 5, 7 };
            Console.WriteLine("228. Summary Ranges:" + APS.SummaryRanges(newArr228));

            String[] newArr139 = { "kfomka", "hecagbngambii", "anobmnikj", "c", "nnkmfelneemfgcl", "ah", "bgomgohl", "lcbjbg", "ebjfoiddndih", "hjknoamjbfhckb", "eioldlijmmla", "nbekmcnakif", "fgahmihodolmhbi", "gnjfe", "hk", "b", "jbfgm", "ecojceoaejkkoed", "cemodhmbcmgl", "j", "gdcnjj", "kolaijoicbc", "liibjjcini", "lmbenj", "eklingemgdjncaa", "m", "hkh", "fblb", "fk", "nnfkfanaga", "eldjml", "iejn", "gbmjfdooeeko", "jafogijka", "ngnfggojmhclkjd", "bfagnfclg", "imkeobcdidiifbm", "ogeo", "gicjog", "cjnibenelm", "ogoloc", "edciifkaff", "kbeeg", "nebn", "jdd", "aeojhclmdn", "dilbhl", "dkk", "bgmck", "ohgkefkadonafg", "labem", "fheoglj", "gkcanacfjfhogjc", "eglkcddd", "lelelihakeh", "hhjijfiodfi", "enehbibnhfjd", "gkm", "ggj", "ag", "hhhjogk", "lllicdhihn", "goakjjnk", "lhbn", "fhheedadamlnedh", "bin", "cl", "ggjljjjf", "fdcdaobhlhgj", "nijlf", "i", "gaemagobjfc", "dg", "g", "jhlelodgeekj", "hcimohlni", "fdoiohikhacgb", "k", "doiaigclm", "bdfaoncbhfkdbjd", "f", "jaikbciac", "cjgadmfoodmba", "molokllh", "gfkngeebnggo", "lahd", "n", "ehfngoc", "lejfcee", "kofhmoh", "cgda", "de", "kljnicikjeh", "edomdbibhif", "jehdkgmmofihdi", "hifcjkloebel", "gcghgbemjege", "kobhhefbbb", "aaikgaolhllhlm", "akg", "kmmikgkhnn", "dnamfhaf", "mjhj", "ifadcgmgjaa", "acnjehgkflgkd", "bjj", "maihjn", "ojakklhl", "ign", "jhd", "kndkhbebgh", "amljjfeahcdlfdg", "fnboolobch", "gcclgcoaojc", "kfokbbkllmcd", "fec", "dljma", "noa", "cfjie", "fohhemkka", "bfaldajf", "nbk", "kmbnjoalnhki", "ccieabbnlhbjmj", "nmacelialookal", "hdlefnbmgklo", "bfbblofk", "doohocnadd", "klmed", "e", "hkkcmbljlojkghm", "jjiadlgf", "ogadjhambjikce", "bglghjndlk", "gackokkbhj", "oofohdogb", "leiolllnjj", "edekdnibja", "gjhglilocif", "ccfnfjalchc", "gl", "ihee", "cfgccdmecem", "mdmcdgjelhgk", "laboglchdhbk", "ajmiim", "cebhalkngloae", "hgohednmkahdi", "ddiecjnkmgbbei", "ajaengmcdlbk", "kgg", "ndchkjdn", "heklaamafiomea", "ehg", "imelcifnhkae", "hcgadilb", "elndjcodnhcc", "nkjd", "gjnfkogkjeobo", "eolega", "lm", "jddfkfbbbhia", "cddmfeckheeo", "bfnmaalmjdb", "fbcg", "ko", "mojfj", "kk", "bbljjnnikdhg", "l", "calbc", "mkekn", "ejlhdk", "hkebdiebecf", "emhelbbda", "mlba", "ckjmih", "odfacclfl", "lgfjjbgookmnoe", "begnkogf", "gakojeblk", "bfflcmdko", "cfdclljcg", "ho", "fo", "acmi", "oemknmffgcio", "mlkhk", "kfhkndmdojhidg", "ckfcibmnikn", "dgoecamdliaeeoa", "ocealkbbec", "kbmmihb", "ncikad", "hi", "nccjbnldneijc", "hgiccigeehmdl", "dlfmjhmioa", "kmff", "gfhkd", "okiamg", "ekdbamm", "fc", "neg", "cfmo", "ccgahikbbl", "khhoc", "elbg", "cbghbacjbfm", "jkagbmfgemjfg", "ijceidhhajmja", "imibemhdg", "ja", "idkfd", "ndogdkjjkf", "fhic", "ooajkki", "fdnjhh", "ba", "jdlnidngkfffbmi", "jddjfnnjoidcnm", "kghljjikbacd", "idllbbn", "d", "mgkajbnjedeiee", "fbllleanknmoomb", "lom", "kofjmmjm", "mcdlbglonin", "gcnboanh", "fggii", "fdkbmic", "bbiln", "cdjcjhonjgiagkb", "kooenbeoongcle", "cecnlfbaanckdkj", "fejlmog", "fanekdneoaammb", "maojbcegdamn", "bcmanmjdeabdo", "amloj", "adgoej", "jh", "fhf", "cogdljlgek", "o", "joeiajlioggj", "oncal", "lbgg", "elainnbffk", "hbdi", "femcanllndoh", "ke", "hmib", "nagfahhljh", "ibifdlfeechcbal", "knec", "oegfcghlgalcnno", "abiefmjldmln", "mlfglgni", "jkofhjeb", "ifjbneblfldjel", "nahhcimkjhjgb", "cdgkbn", "nnklfbeecgedie", "gmllmjbodhgllc", "hogollongjo", "fmoinacebll", "fkngbganmh", "jgdblmhlmfij", "fkkdjknahamcfb", "aieakdokibj", "hddlcdiailhd", "iajhmg", "jenocgo", "embdib", "dghbmljjogka", "bahcggjgmlf", "fb", "jldkcfom", "mfi", "kdkke", "odhbl", "jin", "kcjmkggcmnami", "kofig", "bid", "ohnohi", "fcbojdgoaoa", "dj", "ifkbmbod", "dhdedohlghk", "nmkeakohicfdjf", "ahbifnnoaldgbj", "egldeibiinoac", "iehfhjjjmil", "bmeimi", "ombngooicknel", "lfdkngobmik", "ifjcjkfnmgjcnmi", "fmf", "aoeaa", "an", "ffgddcjblehhggo", "hijfdcchdilcl", "hacbaamkhblnkk", "najefebghcbkjfl", "hcnnlogjfmmjcma", "njgcogemlnohl", "ihejh", "ej", "ofn", "ggcklj", "omah", "hg", "obk", "giig", "cklna", "lihaiollfnem", "ionlnlhjckf", "cfdlijnmgjoebl", "dloehimen", "acggkacahfhkdne", "iecd", "gn", "odgbnalk", "ahfhcd", "dghlag", "bchfe", "dldblmnbifnmlo", "cffhbijal", "dbddifnojfibha", "mhh", "cjjol", "fed", "bhcnf", "ciiibbedklnnk", "ikniooicmm", "ejf", "ammeennkcdgbjco", "jmhmd", "cek", "bjbhcmda", "kfjmhbf", "chjmmnea", "ifccifn", "naedmco", "iohchafbega", "kjejfhbco", "anlhhhhg" };
            Console.WriteLine("139. Word Break:" + DP.WordBreak("fohhemkkaecojceoaejkkoedkofhmohkcjmkggcmnami", newArr139));
            int[][] newArr73 = { new int[] { 0, 1, 1, 0 }, new int[] { 1, 1, 3, 4 }, new int[] { 6, 5, 7, 1 } };
            //Console.WriteLine("NumSquares:" + ArrayProblems.toString(newArr73));
            // test1.SetZeroes(newArr73);
            // Console.WriteLine("NumSquares:" + ArrayProblems.toString(newArr73));
            Console.WriteLine("5. Longest Palindromic Substring:" + DP.LongestPalindrome("aaaaab"));

            int[] newArr238 = { 1, 2 };
            Console.WriteLine("238. Product of Array Except Self:" + ArrayProblems.toString(new List<int>(APS.ProductExceptSelf(newArr238))));

            int[] newArr55 = { 25000, 24999, 24998, 24997, 24996, 24995, 24994, 24993, 24992, 24991, 24990, 24989, 24988, 24987, 24986, 24985, 24984, 24983, 24982, 24981, 24980, 24979, 24978, 24977, 24976, 24975, 24974, 24973, 24972, 24971, 24970, 24969, 24968, 24967, 24966, 24965, 24964, 24963, 24962, 24961, 24960, 24959, 24958, 24957, 24956, 24955, 24954, 24953, 24952, 24951, 24950, 24949, 24948, 24947, 24946, 24945, 24944, 24943, 24942, 24941, 24940, 24939, 24938, 24937, 24936, 24935, 24934, 24933, 24932, 24931, 24930, 24929, 24928, 24927, 24926, 24925, 24924, 24923, 24922, 24921, 24920, 24919, 24918, 24917, 24916, 24915, 24914, 24913, 24912, 24911, 24910, 24909, 24908, 24907, 24906, 24905, 24904, 24903, 24902, 24901, 24900, 24899, 24898, 24897, 24896, 24895, 24894, 24893, 24892, 24891, 24890, 24889, 24888, 24887, 24886, 24885, 24884, 24883, 24882, 24881, 24880, 24879, 24878, 24877, 24876, 24875, 24874, 24873, 24872, 24871, 24870, 24869, 24868, 24867, 24866, 24865, 24864, 24863, 24862, 24861, 24860, 24859, 24858, 24857, 24856, 24855, 24854, 24853, 24852, 24851, 24850, 24849, 24848, 24847, 24846, 24845, 24844, 24843, 24842, 24841, 24840, 24839, 24838, 24837, 24836, 24835, 24834, 24833, 24832, 24831, 24830, 24829, 24828, 24827, 24826, 24825, 24824, 24823, 24822, 24821, 24820, 24819, 24818, 24817, 24816, 24815, 24814, 24813, 24812, 24811, 24810, 24809, 24808, 24807, 24806, 24805, 24804, 24803, 24802, 24801, 24800, 24799, 24798, 24797, 24796, 24795, 24794, 24793, 24792, 24791, 24790, 24789, 24788, 24787, 24786, 24785, 24784, 24783, 24782, 24781, 24780, 24779, 24778, 24777, 24776, 24775, 24774, 24773, 24772, 24771, 24770, 24769, 24768, 24767, 24766, 24765, 24764, 24763, 24762, 24761, 24760, 24759, 24758, 24757, 24756, 24755, 24754, 24753, 24752, 24751, 24750, 24749, 24748, 24747, 24746, 24745, 24744, 24743, 24742, 24741, 24740, 24739, 24738, 24737, 24736, 24735, 24734, 24733, 24732, 24731, 24730, 24729, 24728, 24727, 24726, 24725, 24724, 24723, 24722, 24721, 24720, 24719, 24718, 24717, 24716, 24715, 24714, 24713, 24712, 24711, 24710, 24709, 24708, 24707, 24706, 24705, 24704, 24703, 24702, 24701, 24700, 24699, 24698, 24697, 24696, 24695, 24694, 24693, 24692, 24691, 24690, 24689, 24688, 24687, 24686, 24685, 24684, 24683, 24682, 24681, 24680, 24679, 24678, 24677, 24676, 24675, 24674, 24673, 24672, 24671, 24670, 24669, 24668, 24667, 24666, 24665, 24664, 24663, 24662, 24661, 24660, 24659, 24658, 24657, 24656, 24655, 24654, 24653, 24652, 24651, 24650, 24649, 24648, 24647, 24646, 24645, 24644, 24643, 24642, 24641, 24640, 24639, 24638, 24637, 24636, 24635, 24634, 24633, 24632, 24631, 24630, 24629, 24628, 24627, 24626, 24625, 24624, 24623, 24622, 24621, 24620, 24619, 24618, 24617, 24616, 24615, 24614, 24613, 24612, 24611, 24610, 24609, 24608, 24607, 24606, 24605, 24604, 24603, 24602, 24601, 24600, 24599, 24598, 24597, 24596, 24595, 24594, 24593, 24592, 24591, 24590, 24589, 24588, 24587, 24586, 24585, 24584, 24583, 24582, 24581, 24580, 24579, 24578, 24577, 24576, 24575, 24574, 24573, 24572, 24571, 24570, 24569, 24568, 24567, 24566, 24565, 24564, 24563, 24562, 24561, 24560, 24559, 24558, 24557, 24556, 24555, 24554, 24553, 24552, 24551, 24550, 24549, 24548, 24547, 24546, 24545, 24544, 24543, 24542, 24541, 24540, 24539, 24538, 24537, 24536, 24535, 24534, 24533, 24532, 24531, 24530, 24529, 24528, 24527, 24526, 24525, 24524, 24523, 24522, 24521, 24520, 24519, 24518, 24517, 24516, 24515, 24514, 24513, 24512, 24511, 24510, 24509, 24508, 24507, 24506, 24505, 24504, 24503, 24502, 24501, 24500, 24499, 24498, 24497, 24496, 24495, 24494, 24493, 24492, 24491, 24490, 24489, 24488, 24487, 24486, 24485, 24484, 24483, 24482, 24481, 24480, 24479, 24478, 24477, 24476, 24475, 24474, 24473, 24472, 24471, 24470, 24469, 24468, 24467, 24466, 24465, 24464, 24463, 24462, 24461, 24460, 24459, 24458, 24457, 24456, 24455, 24454, 24453, 24452, 24451, 24450, 24449, 24448, 24447, 24446, 24445, 24444, 24443, 24442, 24441, 24440, 24439, 24438, 24437, 24436, 24435, 24434, 24433, 24432, 24431, 24430, 24429, 24428, 24427, 24426, 24425, 24424, 24423, 24422, 24421, 24420, 24419, 24418, 24417, 24416, 24415, 24414, 24413, 24412, 24411, 24410, 24409, 24408, 24407, 24406, 24405, 24404, 24403, 24402, 24401, 24400, 24399, 24398, 24397, 24396, 24395, 24394, 24393, 24392, 24391, 24390, 24389, 24388, 24387, 24386, 24385, 24384, 24383, 24382, 24381, 24380, 24379, 24378, 24377, 24376, 24375, 24374, 24373, 24372, 24371, 24370, 24369, 24368, 24367, 24366, 24365, 24364, 24363, 24362, 24361, 24360, 24359, 24358, 24357, 24356, 24355, 24354, 24353, 24352, 24351, 24350, 24349, 24348, 24347, 24346, 24345, 24344, 24343, 24342, 24341, 24340, 24339, 24338, 24337, 24336, 24335, 24334, 24333, 24332, 24331, 24330, 24329, 24328, 24327, 24326, 24325, 24324, 24323, 24322, 24321, 24320, 24319, 24318, 24317, 24316, 24315, 24314, 24313, 24312, 24311, 24310, 24309, 24308, 24307, 24306, 24305, 24304, 24303, 24302, 24301, 24300, 24299, 24298, 24297, 24296, 24295, 24294, 24293, 24292, 24291, 24290, 24289, 24288, 24287, 24286, 24285, 24284, 24283, 24282, 24281, 24280, 24279, 24278, 24277, 24276, 24275, 24274, 24273, 24272, 24271, 24270, 24269, 24268, 24267, 24266, 24265, 24264, 24263, 24262, 24261, 24260, 24259, 24258, 24257, 24256, 24255, 24254, 24253, 24252, 24251, 24250, 24249, 24248, 24247, 24246, 24245, 24244, 24243, 24242, 24241, 24240, 24239, 24238, 24237, 24236, 24235, 24234, 24233, 24232, 24231, 24230, 24229, 24228, 24227, 24226, 24225, 24224, 24223, 24222, 24221, 24220, 24219, 24218, 24217, 24216, 24215, 24214, 24213, 24212, 24211, 24210, 24209, 24208, 24207, 24206, 24205, 24204, 24203, 24202, 24201, 24200, 24199, 24198, 24197, 24196, 24195, 24194, 24193, 24192, 24191, 24190, 24189, 24188, 24187, 24186, 24185, 24184, 24183, 24182, 24181, 24180, 24179, 24178, 24177, 24176, 24175, 24174, 24173, 24172, 24171, 24170, 24169, 24168, 24167, 24166, 24165, 24164, 24163, 24162, 24161, 24160, 24159, 24158, 24157, 24156, 24155, 24154, 24153, 24152, 24151, 24150, 24149, 24148, 24147, 24146, 24145, 24144, 24143, 24142, 24141, 24140, 24139, 24138, 24137, 24136, 24135, 24134, 24133, 24132, 24131, 24130, 24129, 24128, 24127, 24126, 24125, 24124, 24123, 24122, 24121, 24120, 24119, 24118, 24117, 24116, 24115, 24114, 24113, 24112, 24111, 24110, 24109, 24108, 24107, 24106, 24105, 24104, 24103, 24102, 24101, 24100, 24099, 24098, 24097, 24096, 24095, 24094, 24093, 24092, 24091, 24090, 24089, 24088, 24087, 24086, 24085, 24084, 24083, 24082, 24081, 24080, 24079, 24078, 24077, 24076, 24075, 24074, 24073, 24072, 24071, 24070, 24069, 24068, 24067, 24066, 24065, 24064, 24063, 24062, 24061, 24060, 24059, 24058, 24057, 24056, 24055, 24054, 24053, 24052, 24051, 24050, 24049, 24048, 24047, 24046, 24045, 24044, 24043, 24042, 24041, 24040, 24039, 24038, 24037, 24036, 24035, 24034, 24033, 24032, 24031, 24030, 24029, 24028, 24027, 24026, 24025, 24024, 24023, 24022, 24021, 24020, 24019, 24018, 24017, 24016, 24015, 24014, 24013, 24012, 24011, 24010, 24009, 24008, 24007, 24006, 24005, 24004, 24003, 24002, 24001, 24000, 23999, 23998, 23997, 23996, 23995, 23994, 23993, 23992, 23991, 23990, 23989, 23988, 23987, 23986, 23985, 23984, 23983, 23982, 23981, 23980, 23979, 23978, 23977, 23976, 23975, 23974, 23973, 23972, 23971, 23970, 23969, 23968, 23967, 23966, 23965, 23964, 23963, 23962, 23961, 23960, 23959, 23958, 23957, 23956, 23955, 23954, 23953, 23952, 23951, 23950, 23949, 23948, 23947, 23946, 23945, 23944, 23943, 23942, 23941, 23940, 23939, 23938, 23937, 23936, 23935, 23934, 23933, 23932, 23931, 23930, 23929, 23928, 23927, 23926, 23925, 23924, 23923, 23922, 23921, 23920, 23919, 23918, 23917, 23916, 23915, 23914, 23913, 23912, 23911, 23910, 23909, 23908, 23907, 23906, 23905, 23904, 23903, 23902, 23901, 23900, 23899, 23898, 23897, 23896, 23895, 23894, 23893, 23892, 23891, 23890, 23889, 23888, 23887, 23886, 23885, 23884, 23883, 23882, 23881, 23880, 23879, 23878, 23877, 23876, 23875, 23874, 23873, 23872, 23871, 23870, 23869, 23868, 23867, 23866, 23865, 23864, 23863, 23862, 23861, 23860, 23859, 23858, 23857, 23856, 23855, 23854, 23853, 23852, 23851, 23850, 23849, 23848, 23847, 23846, 23845, 23844, 23843, 23842, 23841, 23840, 23839, 23838, 23837, 23836, 23835, 23834, 23833, 23832, 23831, 23830, 23829, 23828, 23827, 23826, 23825, 23824, 23823, 23822, 23821, 23820, 23819, 23818, 23817, 23816, 23815, 23814, 23813, 23812, 23811, 23810, 23809, 23808, 23807, 23806, 23805, 23804, 23803, 23802, 23801, 23800, 23799, 23798, 23797, 23796, 23795, 23794, 23793, 23792, 23791, 23790, 23789, 23788, 23787, 23786, 23785, 23784, 23783, 23782, 23781, 23780, 23779, 23778, 23777, 23776, 23775, 23774, 23773, 23772, 23771, 23770, 23769, 23768, 23767, 23766, 23765, 23764, 23763, 23762, 23761, 23760, 23759, 23758, 23757, 23756, 23755, 23754, 23753, 23752, 23751, 23750, 23749, 23748, 23747, 23746, 23745, 23744, 23743, 23742, 23741, 23740, 23739, 23738, 23737, 23736, 23735, 23734, 23733, 23732, 23731, 23730, 23729, 23728, 23727, 23726, 23725, 23724, 23723, 23722, 23721, 23720, 23719, 23718, 23717, 23716, 23715, 23714, 23713, 23712, 23711, 23710, 23709, 23708, 23707, 23706, 23705, 23704, 23703, 23702, 23701, 23700, 23699, 23698, 23697, 23696, 23695, 23694, 23693, 23692, 23691, 23690, 23689, 23688, 23687, 23686, 23685, 23684, 23683, 23682, 23681, 23680, 23679, 23678, 23677, 23676, 23675, 23674, 23673, 23672, 23671, 23670, 23669, 23668, 23667, 23666, 23665, 23664, 23663, 23662, 23661, 23660, 23659, 23658, 23657, 23656, 23655, 23654, 23653, 23652, 23651, 23650, 23649, 23648, 23647, 23646, 23645, 23644, 23643, 23642, 23641, 23640, 23639, 23638, 23637, 23636, 23635, 23634, 23633, 23632, 23631, 23630, 23629, 23628, 23627, 23626, 23625, 23624, 23623, 23622, 23621, 23620, 23619, 23618, 23617, 23616, 23615, 23614, 23613, 23612, 23611, 23610, 23609, 23608, 23607, 23606, 23605, 23604, 23603, 23602, 23601, 23600, 23599, 23598, 23597, 23596, 23595, 23594, 23593, 23592, 23591, 23590, 23589, 23588, 23587, 23586, 23585, 23584, 23583, 23582, 23581 };
            //Console.WriteLine("55. Jump Game:" + DP.CanJump(newArr55));

            int[] newArr611 = { 90, 17, 13, 54, 69, 51, 8, 24, 60, 86, 30, 83, 55, 96, 53, 66, 12, 86, 7, 96, 89, 59, 47, 61, 66, 23, 53, 51, 23, 69, 15, 55, 90, 32, 82, 19, 2, 9, 39, 10, 66, 8, 24, 66, 94, 83, 32, 67, 44, 0, 25, 65, 44, 53, 95, 37, 36, 90, 82, 37, 49, 65, 66, 56, 74, 9, 23, 28, 26, 45, 91, 49, 61, 12, 45, 18, 0, 45, 41, 26, 7, 48, 38, 91, 55, 48, 34, 84, 26, 37, 37, 41, 27, 39, 43, 49, 68, 57, 91, 69 };
            Console.WriteLine("611. Valid Triangle Number:" + APS.TriangleNumber(newArr611));

            int[] newArr92 = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("92. Reverse Linked List II:" + LLP.ReverseBetween(ListNode.arrayToListNode(newArr92), 3, 6).toString());

            int[] newArr24 = { 1, 2 };
            // Console.WriteLine("24. Swap Nodes in Pairs:" + LLP.SwapPairs(ListNode.arrayToListNode(newArr24)).toString());

            int[] newArr61 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            // Console.WriteLine("61. Rotate List:" + LLP.RotateRight(ListNode.arrayToListNode(newArr61), 8).toString());

            int?[] newArr94 = { 1, null, 2, 3 };
            Console.WriteLine("94. Rotate List:" + BT.InorderTraversal(TreeNode.makeTree(newArr94)));

            int?[] newArr102 = { 3, 9, 20, null, null, 15, 7 };
            Console.WriteLine("102. Binary Tree Level Order Traversal:" + BT.LevelOrder(TreeNode.makeTree(newArr102)));

            int?[] newArr145 = { 1, null, 2, 3 };
            Console.WriteLine("145. Binary Tree Postorder Traversal:" + BT.PostorderTraversal(TreeNode.makeTree(newArr145)));

            int?[] newArr144 = { 3, 1, 2 };
            Console.WriteLine("144. Binary Tree Preorder Traversal:" + BT.PreorderTraversal(TreeNode.makeTree(newArr144)));

            int?[] newArr226 = { 4, 2, 7, 1, 3, 6, 9 };
            Console.WriteLine("226. Invert Binary Tree:" + BT.InvertTree(TreeNode.makeTree(newArr226)));

            int[] newArr141 = { -21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5 };
            // Console.WriteLine("141. Linked List Cycle:" + LLP.HasCycle(ListNode.arrayToListNode(newArr141, -1)));

            int[] newArr142 = { -21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5 };
            // Console.WriteLine("142. Linked List Cycle II:" + LLP.DetectCycle(ListNode.arrayToListNode(newArr142, -1)));

            int[] newArr82 = { 1, 2, 3, 3, 4, 4, 5 };
            // Console.WriteLine("82. Remove Duplicates from Sorted List II:" + LLP.DeleteDuplicates(ListNode.arrayToListNode(newArr82)).toString());

            int[] newArr80 = { -50, -50, -49, -40, -40, -40, -40, -40, -40, -39, -38, -38, -38 };
            Console.WriteLine("80. Remove Duplicates from Sorted Array II:" + APS.RemoveDuplicates(newArr80) + ArrayProblems.toString(new List<int>(newArr80)));

            //int[] Arr219 = { 1, 0, 1, 1 };
            // Console.WriteLine("219. Contains Duplicate II:" + APS.ContainsNearbyDuplicate(Arr219, 1));

            //int[] Arr448 = { 1, 1 };
            // Console.WriteLine("448. Find All Numbers Disappeared in an Array:" + ArrayProblems.toString(new List<int>(APS.FindDisappearedNumbers(Arr448))));

            Console.WriteLine("Parallelization");
            Dictionary<string, List<List<int>>> ParallelList = new Dictionary<string, List<List<int>>>();
            List<List<int>> valueList = new List<List<int>>();
            BlockingCollection<string> BlockList = new BlockingCollection<string>();
            ParallelList.Add("SwapNodesInPairs", new List<List<int>>() { new List<int>(newArr24) });
            ParallelList.Add("RemoveDuplicatesfromSortedListII", new List<List<int>>() { new List<int>(newArr82) });
            ParallelList.Add("LinkedListCycle", new List<List<int>>() { new List<int>(newArr141) });
            ParallelList.Add("LinkedListCycleII", new List<List<int>>() { new List<int>(newArr142) });

            Dictionary<string, string> result = new Dictionary<string, string>();
            Parallel.ForEach(ParallelList, async (pair) =>
            {
                await Task.Run(() =>
                {
                    result.Add(pair.Key, LinkListProblems.handler(pair.Key, ParallelList[pair.Key]));
                    BlockList.Add(pair.Key);
                });
            });
            Parallel.ForEach(BlockList.GetConsumingEnumerable(), async (name) =>
            {
                await Task.Run(() =>
               {
                   Console.WriteLine(name + ": " + result[name] + "\r\n");
               });
            });
        }
    }
}
