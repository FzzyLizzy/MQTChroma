# MQTChroma
Control your razer chroma peripherals with an MQTT message

![xmGCXvu](https://user-images.githubusercontent.com/23005387/103112235-59a33f00-4654-11eb-9686-ca534893f369.png)

# MQTT
| Topic        |payload |
| ------------- |:-------------:|
|MQTChroma/{PCNAME}/Chroma| 255,255,255 |

# home assistant configuration
```yaml
light:
  - platform: mqtt
    name: "MQTChroma"
    brightness_scale: 255
    state_topic: "MQTChroma/{PCNAME}/status"
    command_topic: "MQTChroma/{PCNAME}/switch"
    rgb_state_topic: "MQTChroma/{PCNAME}/Chroma"
    rgb_command_topic: "MQTChroma/{PCNAME}/Chroma"
```
