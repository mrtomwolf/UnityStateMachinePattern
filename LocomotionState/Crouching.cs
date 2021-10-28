namespace LocomotionState
{
  public class Crouching : ILocomotionState
  {
    
    public void Crouch(IState context)
    {
      context.SetState(new Grounded());
    }

    public void Fall(IState context) => context.SetState(new InAir());

    public string GetState() => "Crouching";

    public void Jump(IState context) => context.SetState(new Grounded());

    public void Land(IState context)
    {
    }
  }
}