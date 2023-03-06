using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_SD43_BLL.Entities
{
    public class Title :EntityBase
    {
        private string _titleId;
        private string _titleName;
        private string _type;
        private string _publisherId;
        private decimal? _price;
        private decimal? _advance;
        private int? _royalty;
        private int? _yearToDateSales;
        private string _notes;
        private DateTime _publicationDate;

        public string TitleId
        {
            get { return _titleId; }
            set
            {
                if (value != _titleId)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._titleId = value;
                }
            }
        }

        public string TitleName
        {
            get { return _titleName; }
            set
            {
                if (value != _titleName)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._titleName = value;
                }
            }
        }

        public string Type
        {
            get { return _type; }
            set
            {
                if (value != _type)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._type = value;
                }
            }
        }

        public string PublisherId
        {
            get { return _publisherId; }
            set
            {
                if (value != _publisherId)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._publisherId = value;
                }
            }
        }

        public decimal? Price
        {
            get { return _price; }
            set
            {
                if (value != _price)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._price = value;
                }
            }
        }

        public decimal? Advance
        {
            get { return _advance; }
            set
            {
                if (value != _advance)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._advance = value;
                }
            }
        }

        public int? Royalty
        {
            get { return _royalty; }
            set
            {
                if (value != _royalty)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._royalty = value;
                }
            }
        }

        public int? YearToDateSales
        {
            get { return _yearToDateSales; }
            set
            {
                if (value != _yearToDateSales)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._yearToDateSales = value;
                }
            }
        }

        public string Notes
        {
            get { return _notes; }
            set
            {
                if (value != _notes)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._notes = value;
                }
            }
        }

        public DateTime PublicationDate
        {
            get { return _publicationDate; }
            set
            {
                if (value != _publicationDate)
                {
                    if (this.RowState != EntityState.Added)
                        this.RowState = EntityState.Changed;

                    this._publicationDate = value;
                }
            }
        }
    }

}
