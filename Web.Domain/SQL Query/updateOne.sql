﻿ALTER TABLE [dbo].[Videos] ADD [TrillerUrl] [nvarchar](max) NOT NULL DEFAULT ''
DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Tags')
AND col_name(parent_object_id, parent_column_id) = 'Name';
IF @var0 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Tags] DROP CONSTRAINT [' + @var0 + ']')
ALTER TABLE [dbo].[Tags] ALTER COLUMN [Name] [nvarchar](max) NOT NULL
DECLARE @var1 nvarchar(128)
SELECT @var1 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Tags')
AND col_name(parent_object_id, parent_column_id) = 'CreatedBy';
IF @var1 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Tags] DROP CONSTRAINT [' + @var1 + ']')
ALTER TABLE [dbo].[Tags] ALTER COLUMN [CreatedBy] [nvarchar](max) NOT NULL
DECLARE @var2 nvarchar(128)
SELECT @var2 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Tags')
AND col_name(parent_object_id, parent_column_id) = 'UpdatedDate';
IF @var2 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Tags] DROP CONSTRAINT [' + @var2 + ']')
ALTER TABLE [dbo].[Tags] ALTER COLUMN [UpdatedDate] [datetime] NULL
DECLARE @var3 nvarchar(128)
SELECT @var3 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Videos')
AND col_name(parent_object_id, parent_column_id) = 'Name';
IF @var3 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Videos] DROP CONSTRAINT [' + @var3 + ']')
ALTER TABLE [dbo].[Videos] ALTER COLUMN [Name] [nvarchar](max) NOT NULL
DECLARE @var4 nvarchar(128)
SELECT @var4 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Videos')
AND col_name(parent_object_id, parent_column_id) = 'ImageUrl';
IF @var4 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Videos] DROP CONSTRAINT [' + @var4 + ']')
ALTER TABLE [dbo].[Videos] ALTER COLUMN [ImageUrl] [nvarchar](max) NOT NULL
DECLARE @var5 nvarchar(128)
SELECT @var5 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Videos')
AND col_name(parent_object_id, parent_column_id) = 'CreatedBy';
IF @var5 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Videos] DROP CONSTRAINT [' + @var5 + ']')
ALTER TABLE [dbo].[Videos] ALTER COLUMN [CreatedBy] [nvarchar](max) NOT NULL
DECLARE @var6 nvarchar(128)
SELECT @var6 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Videos')
AND col_name(parent_object_id, parent_column_id) = 'UpdatedDate';
IF @var6 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Videos] DROP CONSTRAINT [' + @var6 + ']')
ALTER TABLE [dbo].[Videos] ALTER COLUMN [UpdatedDate] [datetime] NULL
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201803151543196_updateOne', N'Web.Domain.Migrations.Configuration',  0x1F8B0800000000000400ED5DDB6EE4B8117D0F907F10FA2909BCDDBE640613A3BD0B4F7BBC3132BE60DA9EE46DC096D86D6174E99528AF8D60BF2C0FF9A4FC42488992789548497DF1C25860E116C953C562155924AB38FFFBCF7FA73F3D8781F30493D48FA3B3D1D1F870E4C0C88D3D3F5A9D8D32B4FCE1C3E8A71FFFF887E9272F7C76BE96F54E483DDC324ACF468F08AD4F2793D47D842148C7A1EF26711A2FD1D88DC309F0E2C9F1E1E1DF2647471388214618CB71A65FB208F921CC7FE09FB33872E11A6520B88E3D18A4F43B2E99E7A8CE0D0861BA062E3C1BFD132EC6177108FC684C9A2510C191731EF800B33287C172E480288A114098D1D38714CE511247ABF91A7F00C1FDCB1AE27A4B10A49076E0B4AE6EDA97C363D29749DDB08472B31461D6EC008F4EA8702662F34E221E55C2C3E2FB84C58C5E48AF73119E8DAE3C987FFA1207580022C1D3599090CA67A3EB8AC479BABE81685C361C1790970986FB354EBE8F59C403C7B8DD41A54CC7E343F2DF8133CB029425F02C82194A4070E0DC658BC077FF015FEEE3EF303A3B395A2C4F3EBC7B0FBC93F77F8527EFD89EE2BEE27ADC07FCE92E89D730C1BCC165D5FF9133E1DB4DC4865533A64D2115AC4BD82E46CE3578FE0CA3157AC41673FC61E45CFACFD02BBF50E57A887C6C46B8114A32FCF3260B02B00860553E69A449FEDF40F5F8DDFB41A8DE80277F950FBD401F1B4E928E9C2F30C84BD3477F5D981737DEDF68B5CB240EC96F5EBF8AD26FF3384B5CD299585BE51E242B8878EEA6935A798D549A400DAFD625EAFEAB36E154566F6555D2A12E965092D8B63594FC6E96AEB1C6DD83559392312B54DED487E918373970EA825A458E4C5524C2AC779AF12E3ACC7817A5AC7FCE7C4F2136A6DB731427F06718C10420E8DD01846012D556D973A2C37F6E42A1660924DC7E7CD93EE90B4C98922F89934FF77E688FF5B0F606EB861125C2A9CCB5E9A2F2D5F760AC5E55F222BC0EACB8D5A4FE5A2D11E52AC214950B4C275BCE716CAD396FF466CFFB63CF572158C18724D83EE5FBC40F0298EC84F64D162E6052D2BD8AD0C9B135C65DE2BBB54943D70F01EEC95D82FFA25B42BCB2CE5D4000EDD1DFE6D95DCCB3C534DA6596157D75C504DCDB471FDE3FDF7FDFFCB56C3B3FE1C5AC692233DD771A5099C5D1D24FC2DA3A3FC658E540643F838134C543EBFD1DA48F1BB7CF3974B3042BD41C8170BD716A778F7104F9597E1BB4061B9AFB5FE34BE06287E253445AF5C6FB1CBBDFE30C7D8AF209F201B9AD73A40E601076CE5D17A6E9255666E8CDE22C42FD96623295EDFADC6716003F6C3EF8216C7E2BEBC9273F4CB1F6E887ADA35A579A38FC1CAFFCC880C3B29E86C3A2B899435AC796438264C020ADA6E12F2F6D66AFA832D8BA9C8FC7F08B730EFB7B5FA175063FDCBE6A57476FF9F011A21B5F80724A5F41900D4DAA9335E4B63FBC35E4B0FB6F0D399BF8F313F6FF13A323E5B2328637AAAF3EAD6EB73981B36D9B03D7CD6D13DFCE1CA03397F3348D5D3FB702C56522BD0AE2F9C78E9AD37E2F54F446BC5BC21DC38AEEAFB16AE32FB86F2351A96EA30B1840049D73B7B86C9D81D4059E2C46DC21CF82B1EAA85166ACBE63E299FB8B44136B3A4C482340763A29B6543F42B259F891EBAF41D02A25A1A5E11246FA5ED1104B2EE01A468460AB244C88ABAF940803151D6150DA24349D301AD7AC88CCB9866E9C55871CF5F8D253E0B64155C229D425BF206A04B3E89CCAEF6ED366A513AE56E72DDB99CAF5D770461DD28D5A9A42505B343585304CA86B6F7AB7616BAA4D96D1A08B3BAEFD5147619FA7E18C7A849B57475E50DB56475E18AF4B1D8B2DB5D1980BFBEBFD51467E57BF3B1F4496D2B6359193C49E2962E122E33608B780497920B85E5F2CC847F88C147B47CC1FDD3EA6D41317358280CE21E20F926A775CE9264B3E0A0F22AA4D1360AD5A2DA0C515928493FB3D2D4DCB2000A931F5C15A9AD388B3C62E58C9A43CC96C44A4AE88056C79FCD8084B971401965139199B0DBB632AEA83F3445B30DA93553DAB9450B229A32D1483A3D043718AE43B6E2014F63E5316866E57D0B62F60982E95B5A1F78A9D000350F0D6BBA3CAB377FDF06BB70AC69B05A60B54D90C1440E5DB6B34A0ECC3B092298DAE45322AAFD5D86FED2E19C1CDD448A6ECC3B092A116D7221885FF64EA4175170BEFF00C3463948758D50A5D954D27454E01FD309D68920FA6D760BDF6A315938C40BF38F3221361F6C3DC3E423F2C30266EAA08D4AFB8AD28A138012B289462D298D34B3F49D105406001C811DECC0BA56A9C3FA259BB4A52ACCB218F5CB98895B5C9DF450B453E06EFA0C89E1B05B9C45D0B89EF975F8D28065EDDDC215921200089E2366616075918D55D29AE53454DD46314F559141DC27422F442F23925A1491B027E048CC647B689A1C6AAF2FDBA8F971E4227EFD2636725AEF3E2F528E5D9A338FA6A941D8D9CC60FB11B2CE260DB8F8FB295D68C2E7841CAF1A64DADCD0D4887C0840CB230CC67732C2E069045E30ACCF19838404E63EBCFD65845A49F02AD28D81BF5A59E705F052E3679F62AAC69B7AF4A5CC723735C545FCD91D8F862168BFD6ED1331A4BC6F58D7E3347A131C32C08FDF466E6AFDCCC756706DD7D8A9EFE4477FFCFDE8FA0D1AF2C08FD6489C104504A604C9985C57131AE9CE17125E68842202B0B29145970C986AB724CB2059DF0341255D7B0985DA500556E8E954ACD9115A1AA2CB4A2B803B68267B1CC1C5511CDCA022B8A2D66C12AB455B4D03DDE5F690FD0BA4F86C53972BF19518361332DE6107673E3303B35269A905BF5EBCF9658345E5002A3DFF752AFB4C78FDDF5AAB848E8A7571A0CFD24C405E2F1735063F4A01E938BAEE3DDCB86E8423D9E9DD26E5A35F8C34AC5F68ADE6418ECA0684DE52E49B1DB2747AFAA5C5CEEDE439687D1D62A0752EDAFF22BEFB2B11543DA2B5F238630841D3BE231B23C78D269B258A5529DEA5459383D9ED293DCF6F76DA4A3DDA20AC9C92C6C003B682F2982E1985418CF7F0966810FC9725C56B80691BF84292AC28147C787871F841772F6E7B59A499A7A81E2245CF7640D3F7046B1CCBA73E0F658E3BA65717F1B3D81C47D04891C73DBE375971A548A17B88A3CF87C36FA77DEEAD429D9C93F1F3857E943E4FF92E182FB2483CE6F72A2D030AF5DC8C1017A467F7B150F97988BFCEA5FDF8AA607CE6D824DEBD4391404DD65F8F9E74CACB8299AF6E0C6EA91930E83D9EF79822CD7683FD7B8A54F9C87D6B499014CEF4F2178FE73FFDCF67E708A7C7572408406C957D7B2D631275DC5598FC41BC5E9EE9BB635BF70D10F4D7EB5A21F1E9FA3EC136FA4CF3B14DEC6DFA178B3D521DC81E156FBEE4B78CFB5987BF140892AB852DD1F3858F81DCC42F1B8412F05513E60D00B51F148C15078838850F70841172CED03046646D600D89B35ED63045D6663F12902731FB56CB9C34D8AE280D47C6AD21C8D9ACD4F556346F243BB14FBB59591D2C37B99BE9C026E0137689A77BF1DED2B4B9F1E6C315564470F86BD4BBDB7DBC874DC39EB0F52E5BACA33CEF6D1AF48E8F63F06C2A418BC346D97E482FD1E5CE408163C6C3CA97D5FF2D8EB53BADDA6AF1B278DAB2F803BE68C5951DE837475E5DD8B985CD29EA9BE219DAA66338981F604F7AE3AA40B103439FBB1521BDD5D99E5DCBC657D515D8D3123260E96629C7E47BA623A7ADBD414EDEDE3B673A12D5E8AD8A7FC679A69B9E327217AA61B775ABB74B141FB9C706FF1FEC33E2919DDF5EDF8A1875D28992E50689F95CCFC55877DD2B15D3BE1BBD23063177CE7AF35C84994E2B8D2C02A55204ADBAB0C45D4CED9C85B10FFBDD897AA935875646A3DD192AAABA8C8E9F3664592B98B2651C9BFAA809549ED2226DDA848A8F4BB0A579D6DDF28A0D697207482B12343FD8E465AB48E8EA026E3BD892A5D881AA9D23A3AAA9A6C72E560A9B5A02ED20E99521F76F18A85327D5CF5A049CBACAD40D13E8DD2E7D58A2A7BBEE9F10A4D7CA67C4AC070AD7C4B45B35F139BA91E71E9D5C932B5BFB193EA984F716BCBF0AA6073AB1D546DB6067D9243AB86C6CACCCD5A9A3C828105B1891738FA0B829B483581EF030B62F80737FA8B61C8C9CDE2810D39F419BB72CC3F008ADDC9D45FD510E49F038DA0CB3971559DAB681997BEA4C0515945B86CB8860878D8C33B4F90BF042EC2C5E4A63C7F3B37BF6B24F11A0BE85D45B7195A67087719868B80BB87233E6913FDFC15119EE7E9ED3A7FFD7D882E60367D1261701B7DCCFCC0ABF8BE545C74682088B34B6FA1C95822721BBD7AA9906EE2C810888AAFF2D1EF61B80E30587A1BCDC113ECC21B56BFCF7005DC97FA625207D23E10BCD8A7173E5825204C2946DD1EFFC43AEC85CF3FFE1F41E89B7F07770000 , N'6.2.0-61023')

