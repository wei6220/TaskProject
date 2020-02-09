using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject.Tests
{
    [TestClass()]
    public class FindTheDifferenceTaskTests
    {
        [TestMethod()]
        public void FindTheDifferenceTest()
        {
            //Test Case:
            //Input: s = "abcd" , t = "abcde"
            //Output: 'e'
            //Input: s = "aa" , t = "a"
            //Output: 'a'
            //Input: s = "" , t = "y"
            //Output: 'y'
            try
            {
                var qq = new FindTheDifferenceTask()
                    .FindTheDifferenceBest("ymbgaraibkfmvocpizdydugvalagaivdbfsfbepeyccqfepzvtpyxtbadkhmwmoswrcxnargtlswqemafandgkmydtimuzvjwxvlfwlhvkrgcsithaqlcvrihrwqkpjdhgfgreqoxzfvhjzojhghfwbvpfzectwwhexthbsndovxejsntmjihchaotbgcysfdaojkjldprwyrnischrgmtvjcorypvopfmegizfkvudubnejzfqffvgdoxohuinkyygbdzmshvyqyhsozwvlhevfepdvafgkqpkmcsikfyxczcovrmwqxxbnhfzcjjcpgzjjfateajnnvlbwhyppdleahgaypxidkpwmfqwqyofwdqgxhjaxvyrzupfwesmxbjszolgwqvfiozofncbohduqgiswuiyddmwlwubetyaummenkdfptjczxemryuotrrymrfdxtrebpbjtpnuhsbnovhectpjhfhahbqrfbyxggobsweefcwxpqsspyssrmdhuelkkvyjxswjwofngpwfxvknkjviiavorwyfzlnktmfwxkvwkrwdcxjfzikdyswsuxegmhtnxjraqrdchaauazfhtklxsksbhwgjphgbasfnlwqwukprgvihntsyymdrfovaszjywuqygpvjtvlsvvqbvzsmgweiayhlubnbsitvfxawhfmfiatxvqrcwjshvovxknnxnyyfexqycrlyksderlqarqhkxyaqwlwoqcribumrqjtelhwdvaiysgjlvksrfvjlcaiwrirtkkxbwgicyhvakxgdjwnwmubkiazdjkfmotglclqndqjxethoutvjchjbkoasnnfbgrnycucfpeovruguzumgmgddqwjgdvaujhyqsqtoexmnfuluaqbxoofvotvfoiexbnprrxptchmlctzgqtkivsilwgwgvpidpvasurraqfkcmxhdapjrlrnkbklwkrvoaziznlpor"
                    , "qhxepbshlrhoecdaodgpousbzfcqjxulatciapuftffahhlmxbufgjuxstfjvljybfxnenlacmjqoymvamphpxnolwijwcecgwbcjhgdybfffwoygikvoecdggplfohemfypxfsvdrseyhmvkoovxhdvoavsqqbrsqrkqhbtmgwaurgisloqjixfwfvwtszcxwktkwesaxsmhsvlitegrlzkvfqoiiwxbzskzoewbkxtphapavbyvhzvgrrfriddnsrftfowhdanvhjvurhljmpxvpddxmzfgwwpkjrfgqptrmumoemhfpojnxzwlrxkcafvbhlwrapubhveattfifsmiounhqusvhywnxhwrgamgnesxmzliyzisqrwvkiyderyotxhwspqrrkeczjysfujvovsfcfouykcqyjoobfdgnlswfzjmyucaxuaslzwfnetekymrwbvponiaojdqnbmboldvvitamntwnyaeppjaohwkrisrlrgwcjqqgxeqerjrbapfzurcwxhcwzugcgnirkkrxdthtbmdqgvqxilllrsbwjhwqszrjtzyetwubdrlyakzxcveufvhqugyawvkivwonvmrgnchkzdysngqdibhkyboyftxcvvjoggecjsajbuqkjjxfvynrjsnvtfvgpgveycxidhhfauvjovmnbqgoxsafknluyimkczykwdgvqwlvvgdmufxdypwnajkncoynqticfetcdafvtqszuwfmrdggifokwmkgzuxnhncmnsstffqpqbplypapctctfhqpihavligbrutxmmygiyaklqtakdidvnvrjfteazeqmbgklrgrorudayokxptswwkcircwuhcavhdparjfkjypkyxhbgwxbkvpvrtzjaetahmxevmkhdfyidhrdeejapfbafwmdqjqszwnwzgclitdhlnkaiyldwkwwzvhyorgbysyjbxsspnjdewjxbhpsvj");
                Assert.AreEqual(qq, 't');
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void FindTheDifferenceTest2()
        {
            //Test Case:
            //Input: s = "abcd" , t = "abcde"
            //Output: 'e'
            //Input: s = "aa" , t = "a"
            //Output: 'a'
            //Input: s = "" , t = "y"
            //Output: 'y'
            try
            {
                var qq = new FindTheDifferenceTask().FindTheDifferenceBest("abcd", "abcde");
                Assert.AreEqual(qq, 'e');
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        [TestMethod()]
        public void FindTheDifferenceTest3()
        {
            //Test Case:
            //Input: s = "abcd" , t = "abcde"
            //Output: 'e'
            //Input: s = "aa" , t = "a"
            //Output: 'a'
            //Input: s = "" , t = "y"
            //Output: 'y'
            try
            {
                var qq = new FindTheDifferenceTask().FindTheDifferenceBest("aa", "a");
                Assert.AreEqual(qq, 'a');
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void FindTheDifferenceTest4()
        {
            //Test Case:
            //Input: s = "abcd" , t = "abcde"
            //Output: 'e'
            //Input: s = "aa" , t = "a"
            //Output: 'a'
            //Input: s = "" , t = "y"
            //Output: 'y'
            try
            {
                var qq = new FindTheDifferenceTask().FindTheDifferenceBest("", "y");
                Assert.AreEqual(qq, 'y');
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }
}