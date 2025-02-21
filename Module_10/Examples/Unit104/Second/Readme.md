## Пример контрвариативности обобщенных интерфесов

	public interface IMessenger < in T >
	{
	  void GetDeviceInfo(T device);
	}

Для обеспечения контрвариативности интерфейса используется клюевое слово in