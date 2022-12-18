CREATE DATABASE  IF NOT EXISTS `armoptica` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `armoptica`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: armoptica
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `assortiment`
--

DROP TABLE IF EXISTS `assortiment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assortiment` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(100) NOT NULL,
  `ProductTypeID` int NOT NULL,
  `ProductPrice` varchar(10) NOT NULL,
  PRIMARY KEY (`ProductID`),
  KEY `ProductTypeID_idx` (`ProductTypeID`),
  CONSTRAINT `ProductType` FOREIGN KEY (`ProductTypeID`) REFERENCES `producttype` (`ProductTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assortiment`
--

LOCK TABLES `assortiment` WRITE;
/*!40000 ALTER TABLE `assortiment` DISABLE KEYS */;
INSERT INTO `assortiment` VALUES (1,'Алюминиевая оправа',2,'450'),(2,'Солнцезащитные очки светлые',5,'3000'),(3,'Очки для зрения (1.5)',1,'2200'),(4,'Очки для зрения (1.7)',1,'2500'),(5,'Золотая цепочка для очков',6,'1000'),(6,'Чехол для очков \"Авиатор\"',4,'500'),(7,'Чехол для очков \"Круглые\"',4,'350'),(8,'Линзы (1.5)',3,'500'),(9,'Линзы (1.7)',3,'700'),(10,'Сыворотка для глазного контура (0.1 л)',8,'3500'),(11,'Капли для глаз (0.3 л)',8,'500');
/*!40000 ALTER TABLE `assortiment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustID` int NOT NULL AUTO_INCREMENT,
  `CustFIO` varchar(50) NOT NULL,
  `CustTel` varchar(12) NOT NULL,
  `CustAdr` varchar(100) NOT NULL,
  `CustEmail` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`CustID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (12,'Краснова Варвара Матвеевна','+78467898193','Ленинская ул., д. 20 кв.174','varvara01@mail.ru'),(14,'Лаптева Александра Ильинична','+79448598104','Мирная ул., д. 7 кв.38','lapteva571@rambler.ru'),(15,'Сидорова Милана Ильичнина','+92587567955','Колхозная ул., д. 16 кв. 28','sidorovamilana01@yandex.ru'),(18,'Филантропов Михаил Петрович','+79182574128','Красноармейская ул., д. 4 кв. 49',''),(19,'Жукова Ольга Леонидовна','+79548743757','Центральня ул., д. 34 кв. 5',''),(20,'Жуков Михаил Иванович','+79548375432','Центральная ул., д. 34 кв. 5','MIJukov34@gmail.com');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discounts`
--

DROP TABLE IF EXISTS `discounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discounts` (
  `DiscountsID` int NOT NULL AUTO_INCREMENT,
  `DiscountProcent` int NOT NULL,
  `DiscountName` varchar(50) NOT NULL,
  `Promocode` varchar(16) NOT NULL,
  PRIMARY KEY (`DiscountsID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discounts`
--

LOCK TABLES `discounts` WRITE;
/*!40000 ALTER TABLE `discounts` DISABLE KEYS */;
INSERT INTO `discounts` VALUES (1,0,'Без скидки','Default'),(2,10,'10% скидка','10skidka'),(3,20,'20% скидка','20skidka'),(4,30,'30% скидка','30skidka'),(5,40,'40% скидка','40skidka'),(6,50,'50% скидка','50skidka');
/*!40000 ALTER TABLE `discounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `ProductID` int NOT NULL,
  `WorkerID` int NOT NULL,
  `CustID` int NOT NULL,
  `OrderAmount` varchar(10) NOT NULL,
  `DiscountID` int NOT NULL,
  `OrderDate` datetime NOT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `ProductID_idx` (`ProductID`),
  KEY `CustID_idx` (`CustID`),
  KEY `DiscountID_idx` (`DiscountID`),
  KEY `WorkerID_idx` (`WorkerID`),
  CONSTRAINT `AssorimentID` FOREIGN KEY (`ProductID`) REFERENCES `assortiment` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `CustID` FOREIGN KEY (`CustID`) REFERENCES `customers` (`CustID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `DiscountID` FOREIGN KEY (`DiscountID`) REFERENCES `discounts` (`DiscountsID`),
  CONSTRAINT `WorkerID` FOREIGN KEY (`WorkerID`) REFERENCES `workers` (`WorkerID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (3,7,55561,18,'1',4,'2022-12-11 18:01:16'),(6,8,55561,12,'2',1,'2022-12-13 12:24:10'),(7,2,55561,15,'1',6,'2022-12-13 12:29:09'),(8,10,55565,14,'3',3,'2022-12-13 12:40:51'),(9,6,55563,19,'1',1,'2022-12-13 12:51:36'),(10,7,55563,20,'1',1,'2022-12-13 12:51:46'),(11,5,55561,19,'1',3,'2022-12-13 13:18:46'),(12,4,55561,18,'2',5,'2022-12-13 14:21:42'),(13,8,55564,12,'3',6,'2022-12-13 14:46:43'),(14,5,55561,20,'1',6,'2022-12-13 15:18:50'),(15,6,55561,18,'1',3,'2022-12-13 15:24:31'),(16,10,55561,20,'1',3,'2022-12-13 15:25:41'),(17,8,55561,15,'1',3,'2022-12-14 11:29:54');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producttype`
--

DROP TABLE IF EXISTS `producttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producttype` (
  `ProductTypeID` int NOT NULL AUTO_INCREMENT,
  `TypeName` varchar(45) NOT NULL,
  PRIMARY KEY (`ProductTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttype`
--

LOCK TABLES `producttype` WRITE;
/*!40000 ALTER TABLE `producttype` DISABLE KEYS */;
INSERT INTO `producttype` VALUES (1,'Очки для зрения'),(2,'Оправа для очков'),(3,'Линзы'),(4,'Чехол для очков'),(5,'Солнцезащитные очки'),(6,'Цепочки для очков'),(7,'Лупа'),(8,'Капли для глаз');
/*!40000 ALTER TABLE `producttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `store`
--

DROP TABLE IF EXISTS `store`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `store` (
  `PositionID` int NOT NULL AUTO_INCREMENT,
  `ProductID` int NOT NULL,
  `Count` int NOT NULL,
  PRIMARY KEY (`PositionID`),
  KEY `Product_idx` (`ProductID`),
  CONSTRAINT `Product` FOREIGN KEY (`ProductID`) REFERENCES `assortiment` (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `store`
--

LOCK TABLES `store` WRITE;
/*!40000 ALTER TABLE `store` DISABLE KEYS */;
INSERT INTO `store` VALUES (11,6,6),(12,3,8),(13,4,7),(14,1,5),(15,2,8),(16,7,16),(17,5,4),(18,9,23),(19,10,10),(20,11,0),(21,8,16);
/*!40000 ALTER TABLE `store` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Login` varchar(40) NOT NULL,
  `Password` varchar(6) NOT NULL,
  PRIMARY KEY (`Login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('AnukovZV','012345'),('JeffreNV','123457'),('KolotushkinVM','948174'),('PeskovIM','123456'),('RusakovaYG','875649');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workers`
--

DROP TABLE IF EXISTS `workers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workers` (
  `User` varchar(40) NOT NULL,
  `WorkerID` int NOT NULL AUTO_INCREMENT,
  `WorkerFIO` varchar(50) NOT NULL,
  `WorkerPost` varchar(80) NOT NULL,
  `WorkerTel` varchar(12) NOT NULL,
  `WorkerAdr` varchar(100) NOT NULL,
  PRIMARY KEY (`User`),
  UNIQUE KEY `WorkerID_UNIQUE` (`WorkerID`),
  CONSTRAINT `LoginUser` FOREIGN KEY (`User`) REFERENCES `users` (`Login`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=55566 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workers`
--

LOCK TABLES `workers` WRITE;
/*!40000 ALTER TABLE `workers` DISABLE KEYS */;
INSERT INTO `workers` VALUES ('AnukovZV',55562,'Анюков Захар Викторович','Менеджер-продавец','+79247248423','Восточная ул., д. 10 кв.206'),('JeffreNV',55565,'Жеффре Наталия Викторовна','Менеджер-продавец','+79102527233','Восточная ул., д. 15 кв.203'),('KolotushkinVM',55564,'Колотушкин Валентин Маркович','Менеджер-продавец','+79535276524','Спортивная ул., д. 22 кв.61'),('PeskovIM',55561,'Песков Игорь Михайлович','Менеджер-продавец','+78756749014','Прямая ул., д. 5 кв.9'),('RusakovaYG',55563,'Русакова Ярослава Герасимовна','Менеджер-продавец','+79837932658','3 Марта ул., д. 8 кв.81');
/*!40000 ALTER TABLE `workers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'armoptica'
--

--
-- Dumping routines for database 'armoptica'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-18 18:27:24
