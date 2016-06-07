using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NachosMedia.Models;

namespace NachosMedia.Controllers
{
    public class MediaRecordsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MediaRecords
        public async Task<ActionResult> Index()
        {
            return View(await db.MediaRecords.ToListAsync());
        }

        // GET: MediaRecords/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MediaRecord mediaRecord = await db.MediaRecords.FindAsync(id);
            if (mediaRecord == null)
            {
                return HttpNotFound();
            }
            return View(mediaRecord);
        }

        // GET: MediaRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Title,IsPublic,IsAvailable")] MediaRecord mediaRecord)
        {
            if (ModelState.IsValid)
            {
                mediaRecord.Id = Guid.NewGuid();
                db.MediaRecords.Add(mediaRecord);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(mediaRecord);
        }

        // GET: MediaRecords/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MediaRecord mediaRecord = await db.MediaRecords.FindAsync(id);
            if (mediaRecord == null)
            {
                return HttpNotFound();
            }
            return View(mediaRecord);
        }

        // POST: MediaRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Title,IsPublic,IsAvailable")] MediaRecord mediaRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mediaRecord).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mediaRecord);
        }

        // GET: MediaRecords/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MediaRecord mediaRecord = await db.MediaRecords.FindAsync(id);
            if (mediaRecord == null)
            {
                return HttpNotFound();
            }
            return View(mediaRecord);
        }

        // POST: MediaRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            MediaRecord mediaRecord = await db.MediaRecords.FindAsync(id);
            db.MediaRecords.Remove(mediaRecord);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
