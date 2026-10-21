using System.Runtime.CompilerServices;

namespace Section1_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateAndUse();

            // ガベージコレクタを明示的に実行し、デストラクタの完了を待つ
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        // 別メソッドに分離しないとデストラクタが呼び出されない
        // NoInlining: JITによるインライン展開(Mainへの埋め込み)を禁止する
        // 埋め込まれるとsampleへの参照がMain内に残り、GC.Collect()で回収されなくなる
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void CreateAndUse()
        {
            var sample = new Sample();
            sample.Func1();
        }
    }
}
