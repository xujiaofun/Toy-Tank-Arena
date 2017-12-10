using Entitas;

public sealed class RenderSystems : Feature
{
	public RenderSystems (Contexts contexts) : base("RenderSystems")
	{
		Add (new CreateTankViewSystem (contexts));
		Add (new CreateBulletViewSystem (contexts));
		Add (new RotationBarrelSystem (contexts));
		Add (new AdjustTankBodyAngleSystem (contexts));
		Add (new UpdatePositionSystem (contexts));
	}
}
