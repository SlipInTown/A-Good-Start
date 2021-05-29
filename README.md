# Alone in the Estate
Перед вами мой первый проект, который является игрой от 3-го лица в жанре Survival Horror и выполнен на игровом движке "Unity3D". При разработке игры имеется три приоритета: пугающая атмосфера, проработанный геймплей и затягивающий сюжет.

В игре будет предусмотрено
1. Несколько игровых персонажей
2. Реиграбельность
3. Однопользовательский мультиплеер

Как это возможно?
> Однопользовательский мультиплеер

Это означает, что у ИИ в игре будут равные полномочия с игроком. А именно, в процессе решения игровых задач игрок может обнаружить, что задача уже решена без его участия одним из ботов. Игрок начнет думать, что игровой мир живет сам по себе и может обойтись и без него, поэтому он будет больше вовлечен в игровой процесс. 

Примерами таких игр можно считать [Космические рейнджеры 2](https://ru.wikipedia.org/wiki/%D0%9A%D0%BE%D1%81%D0%BC%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B8%D0%B5_%D1%80%D0%B5%D0%B9%D0%BD%D0%B4%D0%B6%D0%B5%D1%80%D1%8B_2:_%D0%94%D0%BE%D0%BC%D0%B8%D0%BD%D0%B0%D1%82%D0%BE%D1%80%D1%8B)
и [Вангеры](https://ru.wikipedia.org/wiki/%D0%92%D0%B0%D0%BD%D0%B3%D0%B5%D1%80%D1%8B).

Как писал Леонид Соловьев
> Дорогу осилит идущий!

###### Космические рейнджеры 2
![Космические рейнджеры 2](https://i.playground.ru/e/7wHFJkRVRCDZzevp4HU35A.jpeg)

###### Вангеры
![Вангеры](https://upload.wikimedia.org/wikipedia/ru/2/26/Vangers_coverart.jpg)

Проект разрабатывается @SlipInTown, визионер @WandererTravel


**Часть кода из проекта**
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class HidePairDoors : MonoBehaviour
{
    [SerializeField] private MeshRenderer anotherDoor;

    [SerializeField] private string _playerTag = "Player"; 
    

    private MeshRenderer meshRenderer;

    void Start()
    { 
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_playerTag))
        {
            meshRenderer.enabled = false;
            anotherDoor.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(_playerTag))
        {
            meshRenderer.enabled = true;
            anotherDoor.enabled = true;
        }
    }
}
```

Данная часть кода, открывает двери в игре при активации триггера игроком. 

## Цели проекта

- [ ] Написать сценарий

- [x] Построить план прохождения

- [ ] Придумать разнообразный геймплей к игре

- [ ] Добавить отсылки на другие произведения

Дата выхода игры | Дата выхода дополнения
------------ | -------------
01.10.2021 | 01.12.2021