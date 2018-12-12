﻿using System;

namespace MathematicsVisualiser.View
{
	/// <summary>
	/// Source: https://stackoverflow.com/a/29823390
	/// </summary>
	static class GenericsHelper
	{

		/// <summary>
		/// Checks, if the typeToCheck is derived from the genericType.
		/// </summary>
		/// <param name="typeToCheck"></param>
		/// <param name="genericType"></param>
		/// <returns> True if the type ir derived from the genericType. </returns>
		public static bool IsOfGenericType(this Type typeToCheck, Type genericType)
		{
			Type concreteType;
			return typeToCheck.IsOfGenericType(genericType, out concreteType);
		}

		/// <summary>
		/// Checks, if the typeToCheck is derived from the genericType and returns the concrete type.
		/// </summary>
		/// <param name="typeToCheck"></param>
		/// <param name="genericType"></param>
		/// <param name="concreteGenericType"></param>
		/// <returns></returns>
		public static bool IsOfGenericType(this Type typeToCheck, Type genericType, out Type concreteGenericType)
		{
			while (true)
			{
				concreteGenericType = null;

				if (genericType == null)
					throw new ArgumentNullException(nameof(genericType));

				if (!genericType.IsGenericTypeDefinition)
					throw new ArgumentException("The definition needs to be a GenericTypeDefinition", nameof(genericType));

				if (typeToCheck == null || typeToCheck == typeof(object))
					return false;

				if (typeToCheck == genericType)
				{
					concreteGenericType = typeToCheck;
					return true;
				}

				if ((typeToCheck.IsGenericType ? typeToCheck.GetGenericTypeDefinition() : typeToCheck) == genericType)
				{
					concreteGenericType = typeToCheck;
					return true;
				}

				if (genericType.IsInterface)
					foreach (var i in typeToCheck.GetInterfaces())
						if (i.IsOfGenericType(genericType, out concreteGenericType))
							return true;

				typeToCheck = typeToCheck.BaseType;
			}
		}

	}
}
