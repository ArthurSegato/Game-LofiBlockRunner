using Godot;

public partial class PlayerMovement : CharacterBody3D
{
	public const float speed = 5.0f;

	public override void _PhysicsProcess(double delta)
	{
        // Use the player input as the direction the character will move
        float direction = Input.GetAxis("move_left","move_right");

		// Velocity = direction of the movement * speed in wich will move
        Velocity = new Vector3(direction * speed, 0, 0);

		// Move character
        MoveAndSlide();
	}
}
