#### 基本信息
 * 姓名: 李晨阳
 * 出生日期: 1995.2.11
 * 毕业院校: 上海理工大学
 * 学历: 本科
 * 居住地: 上海市嘉定区
 * 出生日期: 1995.2.11
 * 邮箱: alucard_invidia@hotmail.com
 * 个⼈博客：http://47.102.128.186/

#### 个⼈技术简介
 * 熟悉C#编程;
 * 了解dotnet core, webapi,aspnet core mvc;
 * 熟悉javascript/nodejs编程,熟悉Express,了解前端开发框架:vue
 * 熟悉RMDB(oracle,sqlserver,sybase) & NoSQL (mongo,redis) & Git;
 * 了解数据库事务机制,存储过程等.具有一定sql调优能力;
 * 了解docker,shell,nginx,pm2;

#### ⼯作经历

>2019/9-/ MES：
>>实现线下门店的日常销售,会员管理,门店调拨收发货等业务,并与oms项目有订单,库存,会员等数据的交互
>>负责模块: 收/发货模块+盘点模块+OMS交互模块等后端接口开发.
>>开发语言(技术): C#.
>>主要框架: asp.net
>>相关技术: castsle + Topshelf
>>技术要点:
>>>主要侧重接口的重构与业务封装.与OMS的交互主要通过消息队列(zeromq)与内部接口.

>2020/3-/ 博客：
>> 前后端利用docker部署,通过nginx反向代理.
>>负责模块: 收/发货模块+盘点模块+OMS交互模块等后端接口开发.
>>开发框架(语言): asp.net webapi(dotnet core latest) + vue 3.0(typescript)
>>相关技术: Entityframework Core(mysql) + castsle + autofac + automapper + redis
>>技术要点:
>>>主要侧重接口的重构与业务封装.与OMS的交互主要通过消息队列(zeromq)与内部接口.

>2018/4-2019/6 云pos：
>>实现线下门店的日常销售,会员管理,门店调拨收发货等业务,并与OMS项目有订单,库存,会员等数据的交互
>>负责模块: 收/发货模块+盘点模块+OMS交互模块等.
>>开发语言(技术): javascript + nodejs.
>>主要框架:miniui + express.js.
>>相关技术: mongo + redis + sybase + nginx + pm2 + shell + zeromq.
>>技术要点:
>>>使用技术与OMS的大致相同.主要侧重接口的重构与业务封装.与OMS的交互主要通过消息队列(zeromq)与内部接口.

>2017/8-2019/6 全渠道订单中台(OMS)：
>>项目简介: 2B应用,接入各个线上电商平台与公司内部平台的订单数据,实现订单,库存相关业务的统一管理.
>>负责模块: 订单/售后模块+商品模块+发票模块等.
>>开发语言(技术): javascript + nodejs + java(少量).
>>主要框架:miniui + express.js + jdbc
>>相关技术: mongo + redis + sybase + nginx + pm2 + shell + zeromq.
>>技术要点:
>>>对接第三方电商平台api与完成内部系统api,基本的crud业务,存储过程等
>>>底层使用java访问sybase数据库
>>>mongo用于订单同步的中间库与记录日志;
>>>redis用于缓存用户session与项目配置数据;
>>>通过消息队列(zeromq)同步中间库至主数据库.
>>>通过pm2+nginx部署应用,shell脚本实现自动部署.