namespace platypus.threeDmaths{
    /*
     * Explain the concept of quaternion rotations in Unity and provide a basic example of how you might use them in a script.
     * 
     * quaternion is a mathamatical represantaion of rotation
     * Quaternions have several advantages over Euler angles, such as avoiding gimbal lock issues and providing smooth interpolation.
     * usecase: a scenario where you want to rotate a GameObject around its local Y-axis
     * Quaternion rotation = Quaternion.Euler(0f, rotationAmount, 0f);
     * // Apply the rotation to the GameObject
     * transform.rotation *= rotation;
     * 
     * basic example 
     *  Create a quaternion for a 45-degree rotation around the Y-axis
     * Quaternion rotationQuaternion = Quaternion.Euler(0f, 45f, 0f);
     *  Slerp between the current rotation and the target's rotation
     * float t = Mathf.PingPong(Time.time, 1f);  Ping-pong between 0 and 1
     * transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, t);
     * // Smoothly follow the target using quaternion look rotation
     * Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);

     
     */
}
