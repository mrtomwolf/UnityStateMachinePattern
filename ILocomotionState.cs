public interface ILocomotionState
{
  string GetState();
  void Jump(IState context);
  void Fall(IState context);
  void Land(IState context);
  void Crouch(IState context);
}