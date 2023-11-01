using Business.Abstract;
using DataAccess.Abstract;
using PixSelectStaj.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VideoManager : IVideoService
    {
        IVideoDal _videoDal;

        public VideoManager(IVideoDal videoDal)
        {
            _videoDal = videoDal;
        }
        public void Add(Video video)
        {
            _videoDal.Add(video);
        }

        public void Delete(Video video)
        {
            _videoDal.Delete(video);
        }

        public Video Get(int id)
        {
            return _videoDal.Get(p=>p.VideoId==id);
        }

        public List<Video> GetAll()
        {
            return _videoDal.GetAll();
        }

        public void Update(Video video)
        {
            _videoDal.Update(video);
        }
    }
}
