create table distribution        --配送订单表
(
订单编号 char(20),               --订单编号
dname char(20),                  --货物名称
dnumber int,                     --货物数量
规格  char(10),					 --货物规格（盒、箱、件）
dprice float,					 --货物单价
dsum   float,					 --订单总价
deliveryman char(20),            --配送员
adress char(20),                 --送货地点地点
receiver char(20),               --收货人
receivertel char(20)             --收货人联系电话
)    