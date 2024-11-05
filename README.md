# unity-test-garage-pickup-objs
Тестовая на Unity: Взятия объектов из А места и перенос их в место Б

1. Подготовил всё для работы. Чётко обозначил, что буду делать, как интерпретировать ТЗ и что добавлю от себя:
	* Создам простой Player Controller (Движение и Поворот). Также будет слот под предмет, в ТЗ этого нет, но реализую, что можно брать лишь один предмет. 
	* Создам IUsed для предметов
	* Простое тестовое, думал надо ли вводить Zenject и New Input System, в итоге отказался от первого и второго. Также выбрал Built-in пайплайн (обычно работаю с URP)
	* Также отказался от ScriptableObject, которые сильно помогают гейм дизам редактировать логику игры
	* Будет сам PickupObj, который надо подобрать и отнести к Warehouse (в ТЗ это будет машина)
	* Будет Garage, он просто должен открыться при старте сцены, притом не буду выделываться со Stencil Buffer. Просто в зданий будет закрытый 2 этаж и туда будет утопать гаражка
	* Уже после первоначальной логики займусь ответлением от ТЗ в виде базового Худа, который показывает, сколько предметов положил в машину и несёт ли он в данный момент предмет
	* Будет ответление от ТЗ в виде скрипта, при нажатий ESC рестартится сцена
2. Приготовил сцену для работы, добавил папки Models и Materials (как в Source движке), добавил капсулку с CharController и туда впихну PlayerMovement, PlayerMouse