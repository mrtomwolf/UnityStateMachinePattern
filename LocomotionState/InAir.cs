using Unity.VisualScripting;

namespace LocomotionState
{
  public class InAir : ILocomotionState
  {
    public void Crouch(IState context)
    {
    }

    public void Fall(IState context)
    {
    }
    
    public string GetState() => "InAir";

    public void Jump(IState context)
    {
    }

    public void Land(IState context) => context.SetState(new Grounded());
  }
}