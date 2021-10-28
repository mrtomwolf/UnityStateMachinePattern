namespace LocomotionState
{
  public class Grounded : ILocomotionState
  {
    public void Crouch(IState context)
    {
      context.SetState(new Crouching());
    }

    public void Fall(IState context) => context.SetState(new InAir());
    
    public string GetState() => "Grounded";

    public void Jump(IState context) => context.SetState(new InAir());

    public void Land(IState context)
    {
    }
  }
}