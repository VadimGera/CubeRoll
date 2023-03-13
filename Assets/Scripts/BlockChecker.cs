using UnityEngine;

public static class BlockChecker
{
    private const float VectorLength = 0.55f;
    private bool CheckIsGrounded(Vector3 position)
    {
        return Physics.Raycast(position, Vector3.down, VectorLength);
    }

    private bool HasWallInDirection(Vector3 position, Vector3 direction)
    {
        return Physics.Raycast(position, direction, VectorLength);
    }
}