-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.0.36 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para club_deportivo
CREATE DATABASE IF NOT EXISTS `club_deportivo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `club_deportivo`;

-- Volcando estructura para procedimiento club_deportivo.IngresoLogin
DELIMITER //
CREATE PROCEDURE `IngresoLogin`(
	IN `Usu` VARCHAR(50),
	IN `Pass` VARCHAR(50)
)
BEGIN
    SELECT * 
    FROM usuarios 
    WHERE NombreUsu  = Usu	 
      AND PassUsu  = Pass;
END//
DELIMITER ;

-- Volcando estructura para procedimiento club_deportivo.InsertarSocio
DELIMITER //
CREATE PROCEDURE `InsertarSocio`(
    IN _Nombre VARCHAR(50),
    IN _Apellido VARCHAR(50),
    IN _DNI VARCHAR(50),
    IN _Telefono VARCHAR(50),
    IN _FechaAlta DATE,
    IN _FechaVencimientoCuota DATE, 
    IN _CarnetEntregado TINYINT(1),
    IN _Activo TINYINT(1) 
)
BEGIN
    INSERT INTO socios (Nombre, Apellido, DNI, Telefono, FechaAlta, FechaVencimientoCuota, CarnetEntregado, Activo)
    VALUES (_Nombre, _Apellido, _DNI, _Telefono, _FechaAlta, _FechaVencimientoCuota, _CarnetEntregado, _Activo);
END//
DELIMITER ;

-- Volcando estructura para tabla club_deportivo.nosocios
CREATE TABLE IF NOT EXISTS `nosocios` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `DNI` varchar(50) DEFAULT NULL,
  `PagoDiario` varchar(50) DEFAULT NULL,
  `Actividades` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla club_deportivo.nosocios: ~0 rows (aproximadamente)
DELETE FROM `nosocios`;

-- Volcando estructura para tabla club_deportivo.socios
CREATE TABLE IF NOT EXISTS `socios` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL DEFAULT '',
  `Apellido` varchar(50) NOT NULL DEFAULT '',
  `DNI` varchar(50) NOT NULL DEFAULT '',
  `Telefono` varchar(50) DEFAULT '',
  `FechaAlta` date DEFAULT NULL,
  `FechaVencimientoCuota` date DEFAULT NULL,
  `CarnetEntregado` tinyint NOT NULL,
  `Activo` tinyint NOT NULL,
  `Actividades` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla club_deportivo.socios: ~2 rows (aproximadamente)
DELETE FROM `socios`;
INSERT INTO `socios` (`Id`, `Nombre`, `Apellido`, `DNI`, `Telefono`, `FechaAlta`, `FechaVencimientoCuota`, `CarnetEntregado`, `Activo`, `Actividades`) VALUES
	(4, 'maxi', 'alem', '11254425', '11254424', '2024-10-20', NULL, 0, 1, NULL),
	(5, 'pancho', 'doto', '031245851', '1234585525', '2024-10-20', NULL, 0, 1, NULL);

-- Volcando estructura para tabla club_deportivo.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `CodUsu` int NOT NULL,
  `NombreUsu` varchar(20) DEFAULT NULL,
  `PassUsu` varchar(15) DEFAULT NULL,
  `RolUsu` int DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Volcando datos para la tabla club_deportivo.usuarios: ~1 rows (aproximadamente)
DELETE FROM `usuarios`;
INSERT INTO `usuarios` (`CodUsu`, `NombreUsu`, `PassUsu`, `RolUsu`, `Activo`) VALUES
	(26, 'admin', '123', 120, 1);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
