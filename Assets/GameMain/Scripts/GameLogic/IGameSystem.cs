
namespace GameTowerDefense
{
	public interface IGameSystem<T> where T:GameLogicBase
	{
  		T GameLogic { get; }

	    void Init(T gameLogic);

		void Update();

		void OnDestroy();

		

	}
}

