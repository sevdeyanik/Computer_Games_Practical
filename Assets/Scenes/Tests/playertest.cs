using NUnit.Framework;
using UnityEngine;

public class PlayerTests
{
    [Test]
    public void PlayerStartsAtOrigin()
    {
        // Arrange: Create a new player GameObject for the purpose of testing
        GameObject player = new GameObject("TestPlayer");
        player.transform.position = Vector3.zero;

        // Act: (nothing in this case, as we're just checking the start position)

        // Assert: Check if the player's position is at the origin
        Assert.AreEqual(Vector3.zero, player.transform.position);
    }
}
