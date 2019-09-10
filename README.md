# Universidad Católica del Uruguay
## Facultad de Ingeniería y Tecnologías
### Programación II
Código de ejemplo del patrón [Observer](https://en.wikipedia.org/wiki/Observer_pattern)

El ejemplo consiste esencialmente de tres clases:
* Temperature
* TemperatureMonitor
* TemperatureReporter

### Temperature
Representa una lectura de un sensor de temperatura

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Conocer una lectura de temperatura ||
| Conocer la fecha y hora en que se leyó la temperatura ||

### TemperatureMonitor
Representa un sensor de temperatura

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Conocer la temperatura actual | Temperature |
| Conocer los reportadores interesados en la temperatura actual | TemperatureReporter |
| Agregar un reportador interesado ||
| Remover un reportador previamente agregado ||

### TemperatureReporter
Representa un dispositivo capaz de mostrar valores (por ejemplo un display de siete segmentos o un monitor)

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Conectarse a un monitor de temperatura | TemperatureMonitor |
| Desconectarse de un monitor de tempratura ||
| Recibir actualizaciones del monitor de temperatura ||

### Diagramas
A continuación mostramos esas clases en un diagrama:
![Diagrama de clases](https://github.com/ucudal/PII_Observer_Start/blob/master/images/Observer-Clases.svg?sanitize=true)

Este es un diagrama de los mensajes intercambiados entre las clases:
![Diagrama de interacciones](https://github.com/ucudal/PII_Observer_Start/blob/master/images/Observer-Interacciones.svg?sanitize=true)

### Desafio
Modifiquen las clases provistas para que exista un tipo `Observable` y otro `Observer` con estas responsabilidades
de hacer:

### Observable
Representa un objeto observable que notifica sus cambios a objetos observadores; este objeto no conoce a priori a los
observadores a notificar sino que éstos se suscriben a demanda.

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Conocer los observadores interesados cambios en este objeto | Observer |
| Agregar un observador ||
| Remover un observador previamente agregado ||
| Notificar cambios en este objeto a los observadores ||

### Observer
Representa un objeto observador que desea conocer cambios en otro objeto observado

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Recibir actualizaciones cuando haya cambios en el objeto observado | Observable |