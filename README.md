[changelog]
- 不允许多实例的UI界面，被重复打开时不再直接返回null，不需要手动先关闭该界面才能打开，而是逻辑上先自动关闭该界面再打开。
- 优化流程模块：任意类任意时刻均可获取到指定流程。
- 移除DataNode模块。
- GameFramework中的定义移入UnityGameFramework。