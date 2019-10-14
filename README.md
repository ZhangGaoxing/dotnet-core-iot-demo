# dotnet-core-iot-demo

## License
This repository is licensed under the [__MIT License__](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE) © [Zhang Yuexin](https://zhangyue.xin)

## Pin Map
![](https://raw.githubusercontent.com/ZhangGaoxing/dotnet-core-iot-demo/master/img/RP2_Pinout.png)

## Run the Sample with Docker
Connect the circuit according to `README.md` under the **samples** folder. Before running the Docker image, you should use the `--device` parameter to mount hardware devices.

```
docker build -t SAMPLE_NAME -f Dockerfile .
docker run --rm -it --device=/dev/i2c-1 SAMPLE_NAME
```

## Catalogue

### I2C
* Analog-to-Digital Converter [ADS1115](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Ads1115)
* MEMS VOC Gas Sensor [AGS01DB](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Ags01db)
* Digital Light Sensor [BH1750FVI](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Bh1750fvi)
* 3-Axis Digital Compass [HMC5883L](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Hmc5883l)
* Digital Temperature Sensor [LM75](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Lm75)
* Digital Light Sensor [MAX44009](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Max44009)
* Infra Red thermometer Sensor [MLX90614](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Mlx90614)
* Radio Receiver [RadioReceiver](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/RadioReceiver)
* Radio Transmitter [RadioTransmitter](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/RadioTransmitter)
* Real Time Clock [RTC](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Rtc)
* Temperature & Humidity Sensor [SHT3x](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Sht3x)
* Temperature & Humidity Sensor [Si7021](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Si7021)

### SPI
* SPI Accelerometer [ADXL345](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Adxl345)
* Single chip 2.4 GHz Transceiver [NRF24L01](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Nrf24l01)

### GPIO
* Temperature & Humidity Sensor [DHTxx](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/Dhtxx)
* Ultrasonic Distance Sensor [HC-SR04](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/HCsr04)
* PIR Motion Sensor [HC-SR501](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/HCsr501)

### Others
* On-board LED driver [BoardLed](https://github.com/ZhangGaoxing/dotnet-core-iot-demo/tree/master/src/BoardLed)