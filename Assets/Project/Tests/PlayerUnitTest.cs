using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerUnitTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PlayerUnitTestSimplePasses()
        {
            var gameObject = new GameObject();
            var playerUnit = gameObject.AddComponent<PlayerUnit>();
            var beforePosition = playerUnit.transform.position;
            playerUnit.Move(Vector3.up);
            Assert.AreNotEqual(beforePosition, playerUnit.transform.position);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator PlayerUnitMoveTest()
        {


            yield return null;
        }
    }
}
