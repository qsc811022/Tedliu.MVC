# Tedliu.MVC
永慶房屋
訂便當系統
![image](https://github.com/qsc811022/Tedliu.MVC/blob/master/indexPage.PNG)



# USE [DemoProject]
# GO
# /****** Object:  Table [dbo].[FoodTable]    Script Date: 2022/1/14 下午 12:36:21 ******/
# SET ANSI_NULLS ON
# GO
# SET QUOTED_IDENTIFIER ON
# GO
# CREATE TABLE [dbo].[FoodTable](
#	[id] [int] IDENTITY(1,1) NOT NULL,
#	[FoodName] [varchar](50) NOT NULL,
#	[FoodPrice] [int] NOT NULL,
#	[dep] [varchar](50) NOT NULL,
#	[Name] [varchar](50) NOT NULL,
# CONSTRAINT [PK_FoodTable] PRIMARY KEY CLUSTERED 
# (
#	[id] ASC
# )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
# ) ON [PRIMARY]
# GO
