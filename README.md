# WT-6 ASP.NET Core Minimal API — Автосалон

## Репозиторий

https://github.com/ekaterin673936-creator/wt-lab6-6minimalapi-zhiznevskaya

## API Endpoints

| Метод | URL | Назначение |
|-------|-----|------------|
| GET | `/` | Проверка работы API |
| GET | `/api/info` | Информация о приложении |
| GET | `/api/cars` | Список всех автомобилей (с фильтрацией `?search=`) |
| GET | `/api/cars/{id}` | Получить автомобиль по Id |
| POST | `/api/cars` | Создать новый автомобиль |
| PUT | `/api/cars/{id}` | Обновить автомобиль |
| DELETE | `/api/cars/{id}` | Удалить автомобиль |

## HTTP-статусы

| Ситуация | Статус |
|----------|--------|
| Успешный GET | 200 OK |
| Успешный POST | 201 Created |
| Успешный DELETE | 204 No Content |
| Некорректные данные | 400 Bad Request |
| Объект не найден | 404 Not Found |

## Swagger UI

http://localhost:5293/swagger