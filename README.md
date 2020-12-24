# MQTChroma
Control your razer chroma peripherals with an MQTT message

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
