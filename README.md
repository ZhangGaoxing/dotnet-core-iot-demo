# dotnet-core-iot-demo

## License
This repository is licensed under the [__MIT License__](LICENSE) © [Zhang Yuexin](https://zhangyue.xin)

## Pin Map
![](img/RP2_Pinout.png)

## Run the Sample with Docker
Connect the circuit according to `README.md` under the **samples** folder. Before running the Docker image, you should use the `--device` parameter to mount hardware devices.

```
docker build -t SAMPLE_NAME -f Dockerfile .
docker run --rm -it --device=/dev/i2c-1 SAMPLE_NAME
```

## Catalogue

### Hardware
* I2C
  * Analog-to-Digital Converter [ADS1115](src/Ads1115)
  * MEMS VOC Gas Sensor [AGS01DB](src/Ags01db)
  * Digital Light Sensor [BH1750FVI](src/Bh1750fvi)
  * 3-Axis Digital Compass [HMC5883L](src/Hmc5883l)
  * Digital Temperature Sensor [LM75](src/Lm75)
  * Digital Light Sensor [MAX44009](src/Max44009)
  * Infra Red thermometer Sensor [MLX90614](src/Mlx90614)
  * Radio Receiver [RadioReceiver](src/RadioReceiver)
  * Radio Transmitter [RadioTransmitter](src/RadioTransmitter)
  * Real Time Clock [RTC](src/Rtc)
  * Temperature & Humidity Sensor [SHT3x](src/Sht3x)
  * Temperature & Humidity Sensor [Si7021](src/Si7021)
* SPI
  * SPI Accelerometer [ADXL345](src/Adxl345)
  * Single chip 2.4 GHz Transceiver [NRF24L01](src/Nrf24l01)
* GPIO
  * Temperature & Humidity Sensor [DHTxx](src/Dhtxx)
  * Ultrasonic Distance Sensor [HC-SR04](src/HCsr04)
  * PIR Motion Sensor [HC-SR501](src/HCsr501)
* Others
  * On-board LED driver [BoardLed](src/BoardLed)

### Sample
* Hello World! [Blink](src/Blink)
* Serial Port Demo [SerialCommunication](src/SerialCommunication)
* Hardware PWM [PwmLed](src/PwmLed)
* Software PWM [PwmRgb](src/PwmRgb)