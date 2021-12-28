﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="antran2598_test")]
	public partial class MydbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChitietNV(ChitietNV instance);
    partial void UpdateChitietNV(ChitietNV instance);
    partial void DeleteChitietNV(ChitietNV instance);
    #endregion
		
		public MydbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["antran2598_testConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChitietNV> ChitietNVs
		{
			get
			{
				return this.GetTable<ChitietNV>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChitietNV")]
	public partial class ChitietNV : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Manv;
		
		private string _Ten;
		
		private string _Chucvu;
		
		private string _Phongban;
		
		private string _Chuthich;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnManvChanging(int value);
    partial void OnManvChanged();
    partial void OnTenChanging(string value);
    partial void OnTenChanged();
    partial void OnChucvuChanging(string value);
    partial void OnChucvuChanged();
    partial void OnPhongbanChanging(string value);
    partial void OnPhongbanChanged();
    partial void OnChuthichChanging(string value);
    partial void OnChuthichChanged();
    #endregion
		
		public ChitietNV()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manv", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Manv
		{
			get
			{
				return this._Manv;
			}
			set
			{
				if ((this._Manv != value))
				{
					this.OnManvChanging(value);
					this.SendPropertyChanging();
					this._Manv = value;
					this.SendPropertyChanged("Manv");
					this.OnManvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this.OnTenChanging(value);
					this.SendPropertyChanging();
					this._Ten = value;
					this.SendPropertyChanged("Ten");
					this.OnTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chucvu", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Chucvu
		{
			get
			{
				return this._Chucvu;
			}
			set
			{
				if ((this._Chucvu != value))
				{
					this.OnChucvuChanging(value);
					this.SendPropertyChanging();
					this._Chucvu = value;
					this.SendPropertyChanged("Chucvu");
					this.OnChucvuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phongban", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Phongban
		{
			get
			{
				return this._Phongban;
			}
			set
			{
				if ((this._Phongban != value))
				{
					this.OnPhongbanChanging(value);
					this.SendPropertyChanging();
					this._Phongban = value;
					this.SendPropertyChanged("Phongban");
					this.OnPhongbanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chuthich", DbType="NVarChar(50)")]
		public string Chuthich
		{
			get
			{
				return this._Chuthich;
			}
			set
			{
				if ((this._Chuthich != value))
				{
					this.OnChuthichChanging(value);
					this.SendPropertyChanging();
					this._Chuthich = value;
					this.SendPropertyChanged("Chuthich");
					this.OnChuthichChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
