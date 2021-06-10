DROP TABLE IF EXISTS `file_information`;

CREATE TABLE `file_information` (
  `id` int NOT NULL,
  `item_name` varchar(45) NOT NULL,
  `quantity` varchar(45) NOT NULL,
  `location` varchar(45) DEFAULT NULL
)

DROP TABLE IF EXISTS `po`;

CREATE TABLE `po` (
  `PO` varchar(45) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `item_number` int NOT NULL,
  `item_name` varchar(45) DEFAULT NULL,
  `qty_ordered` int DEFAULT NULL
)

DROP TABLE IF EXISTS `wo`;

CREATE TABLE `wo` (
  `wonum` varchar(45) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `item_number` int DEFAULT NULL,
  `item_name` varchar(45) DEFAULT NULL,
  `qty` int DEFAULT NULL
)