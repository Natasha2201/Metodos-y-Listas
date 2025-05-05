# 📝 Metodos y listas en C#

Este proyecto es una aplicación de escritorio desarrollada en **Windows Forms con C#**, que permite al usuario **agregar y eliminar elementos** de una lista con validación de entradas.

---

## 🧩 Funcionalidades

- ➕ **Agregar elementos**: solo permite texto con letras y espacios.
- ❌ **Eliminar elementos** seleccionados de la lista.
- 🔄 **Actualización dinámica** del `ListBox` al agregar o eliminar elementos.
- 🚫 Muestra mensajes de error si se intenta ingresar datos inválidos o duplicados.

---

## 🖼️ Interfaz

- `txtElemento`: Caja de texto para ingresar nuevos elementos.
- `btnAgregar`: Botón para añadir el texto a la lista.
- `btnEliminar`: Botón para eliminar el elemento seleccionado.
- `lstElementos`: ListBox que muestra los elementos actuales.

---

## 🛠️ Validaciones

- ✅ Solo se aceptan letras y espacios (`[a-zA-Z\s]+`).
- ⚠️ No se permiten entradas vacías, duplicadas o con números/símbolos.

---

## ▶️ Cómo ejecutar

1. Abre el proyecto en **Visual Studio**.
2. Ejecuta con `F5`.
3. Ingresa elementos válidos y experimenta con agregar y eliminar desde la lista.
