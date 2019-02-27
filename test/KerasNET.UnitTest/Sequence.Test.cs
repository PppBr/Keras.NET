using Keras;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSharp.Core;

namespace KerasNET.UnitTest
{
    [TestClass]
    public class SequenceTest
    {
        [TestMethod]
        public void pad_sequences()
        {
            var nd = np.arange(3);
            nd = keras.preprocessing.sequence.pad_sequences(nd, 5);
        }
    }
}
